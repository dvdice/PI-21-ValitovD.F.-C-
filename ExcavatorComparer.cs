using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class ExcavatorComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is CleanerVehicle && y is CleanerVehicle)
            {
                return ComparerCrane((CleanerVehicle)x, (CleanerVehicle)y);
            }
            if (x is CleanerVehicle && y is Excavator)
            {
                return 1;
            }
            if (x is Excavator && y is CleanerVehicle)
            {
                return -1;
            }
            if (x is Excavator && y is CleanerVehicle)
            {
                return ComparerTrackedVehicle((Excavator)x, (CleanerVehicle)y);
            }
            return 0;
        }
        private int ComparerTrackedVehicle(Excavator x, Excavator y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerCrane(CleanerVehicle x, CleanerVehicle y)
        {
            int res = ComparerTrackedVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontScoop != y.FrontScoop)
            {
                return x.FrontScoop.CompareTo(y.FrontScoop);
            }
            if (x.BackBrush != y.BackBrush)
            {
                return x.BackBrush.CompareTo(y.BackBrush);
            }
            return 0;
        }
    }
}
