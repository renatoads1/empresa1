using System;
using System.Collections.Generic;
using System.Text;

namespace empresa1.Entities
{
    class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            this.Data = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() 
        {
            return Hours * ValuePerHour;
        }
    }
}
