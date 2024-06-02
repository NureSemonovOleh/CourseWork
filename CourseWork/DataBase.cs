using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseWork
{
    public class DataBase
    {
        public List<Car> Cars = new List<Car>();
        public List<Customer> Customers = new List<Customer>();
        public List<Request> Requests = new List<Request>();
        public Dictionary<string, List<string>> carModels;
        public DataBase() {
            InitializeCarModels();
        }
        private void InitializeCarModels()
        {
            carModels = new Dictionary<string, List<string>>
            {
                {"Toyota", new List<string> {"Supra","Corolla","Chaser"} },
                {"Nissan", new List<string>{"Skyline","240sx","350z"} },
                {"Ford", new List<string>{"Mustang", "GT", "Focus"} }
            };

        }
        public void SaveFile(string filePath)
        {
            var data = new
            {
                Cars,
                Customers,
                Requests

            };
            var jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        public void LoadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                var data = JsonConvert.DeserializeObject<DataBase>(jsonData);

                Cars = data.Cars;
                Customers = data.Customers;
                Requests = data.Requests;
            }
        }
        

    }

}
