using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityPostgreSQL
{   
    public static class JsonFileManager
    {
        internal static void SaveToJson(List<Car> cars, string fileName)
        {
            var json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

        internal static List<Car> LoadFromJson(string fileName)
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<List<Car>>(json);
            }
            return new List<Car>();
        }
    }
}
