using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        public void DelParking(String name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind] => parkingStages.ContainsKey(ind) ? parkingStages[ind] : null;
        
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename, true, Encoding.UTF8))
            {
                fs.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    fs.WriteLine($"Parking{separator}{level.Key}");
                    ITransport excavator = null;

                    for (int i = 0; (excavator = level.Value.GetNext(i)) != null; i++)
                    {
                        if (excavator != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (excavator.GetType().Name == "Excavator")

                            {
                                fs.Write($"Excavator{separator}");

                            }

                            if (excavator.GetType().Name == "CleanerVehicle")

                            {
                                fs.Write($"CleanerVehicle{separator}");
                            }

                            //Записываемые параметры
                            fs.WriteLine(excavator.ToString());

                        }
                    }
                }
            } 
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader fs = new StreamReader(filename, Encoding.UTF8))
            {
                string data = fs.ReadLine();
                string key = string.Empty;
                if (data.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то не те данные
                    throw new Exception("Неверный формат файла");
                }
                while ((data = fs.ReadLine()) != null)
                {
                    Vehicle excavator = null;

                    if (data.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = data.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(data))
                    {
                        continue;
                    }
                    if (data.Split(separator)[0] == "Excavator")
                    {
                        excavator = new Excavator(data.Split(separator)[1]);
                    }
                    else if (data.Split(separator)[0] == "CleanerVehicle")
                    {
                        excavator = new CleanerVehicle(data.Split(separator)[1]);
                    }
                    if (!(parkingStages[key] + excavator))
                    {
                        throw new Exception("Не удалось загрузить автомобиль на парковку"); 
                    }
                }
            }
        }
    }
}
