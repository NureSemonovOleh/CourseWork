using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Condition { get; set; }
        public int MaxSpeed { get; set; }
        public decimal EngineVolume { get; set; }
        public int Price { get; set; }

        public Request Request
        {
            get => default;
            set
            {
            }
        }

        public DataBase DataBase
        {
            get => default;
            set
            {
            }
        }
    }
}
