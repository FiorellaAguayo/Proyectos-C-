using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TransportCompany
    {
        private Driver[] _drivers;

        public TransportCompany(Driver[] drivers)
        {
            _drivers = drivers;
        }

        public Driver[] Drivers { get { return _drivers; } }

        public Driver DriverMoreKmPerWeek()
        {
            Driver driverMoreKmPerWeek = null;
            int maxKm = 0;

            foreach (Driver driver in Drivers)
            {
                int totalKm = 0;
                foreach (int km in driver.Km)
                {
                    totalKm += km;
                }

                if (totalKm > maxKm)
                {
                    maxKm = totalKm;
                    driverMoreKmPerWeek = driver;
                }
            }

            return driverMoreKmPerWeek;
        }

        public Driver DriverMoreKmPerDay(int day)
        {
            Driver driverMoreKmPerDay = null;
            int maxKm = 0;

            foreach (Driver driver in Drivers)
            {
                int kmPerDay = driver.Km[day - 1]; // km ese dia, es menos 1 porque el array empieza en 0

                if (kmPerDay > maxKm)
                {
                    maxKm = kmPerDay;
                    driverMoreKmPerDay = driver;
                }
            }
            return driverMoreKmPerDay;
        }
    }
}