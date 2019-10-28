using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Helpers.Utilities
{
    public class JsonSqlLoader
    {
        public string _filename { get; set; }
        public JsonSqlLoader(string filename)
        {
            _filename = filename;
        }

        public IEnumerable<Queries> LoadSQLQueries()
        {
            if (File.Exists(_filename))
            {
                using (StreamReader sr = new StreamReader(_filename))
                {
                    var deserializedProduct = JsonConvert.DeserializeObject<List<Queries>>(sr.ReadToEnd());
                    return deserializedProduct;
                }
            }
            else
            {
                throw new FileNotFoundException(_filename + " Not Exists");
            }
        }
    }

    public class Queries
    {
        public string QueryDescription { get; set; }
        public string QueryValue { get; set; }
    }

}
