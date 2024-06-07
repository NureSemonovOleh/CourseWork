using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string PrefferedBrand { get; set; }
        public int PrefferedYear { get; set; }
        public string PrefferedCondition { get; set; }
        public int Budget { get; set; }

        public Request Request
        {
            get => default;
            set
            {
            }
        }

        public Request Request1
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
