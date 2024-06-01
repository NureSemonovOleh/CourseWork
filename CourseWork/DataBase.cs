using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
        public async Task Save(string FilePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            using(FileStream fs = new FileStream(FilePath,FileMode.Create, FileAccess.Write)) {
                await JsonSerializer.SerializeAsync(fs, this, options);
            }



        }
        public static async Task<DataBase> Load(string filePath)
        {
            using (FileStream fs = new FileStream(filePath,FileMode.Open, FileAccess.Read))
            {
                return await JsonSerializer.DeserializeAsync<DataBase>(fs);
            }
        }
    }

}
