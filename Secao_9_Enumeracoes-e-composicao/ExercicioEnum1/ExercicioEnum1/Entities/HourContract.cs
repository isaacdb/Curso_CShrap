using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnum1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public float ValuePerHour { get; set; }
        public float Hours { get; set; }

        public HourContract(DateTime date, float valuePerHour, float hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public float TotalValue() {
            return (float)(ValuePerHour * Hours);
        }
    }
}
