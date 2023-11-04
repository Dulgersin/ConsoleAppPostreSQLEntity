using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityPostgreSQL
{
    internal class Car
    {
        public int Id { get; set; }

        //Конвертирует Enum в строковое значение, когда сохраняет в json, а не int формат.
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumCarsBrands Brand { get; set; }

        public string Model { get; set; }
    }
}
