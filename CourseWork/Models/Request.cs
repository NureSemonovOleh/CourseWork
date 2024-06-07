using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Request
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }

        public DataBase DataBase
        {
            get => default;
            set
            {
            }
        }
    }
}
