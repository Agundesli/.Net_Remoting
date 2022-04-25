using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzakNesne
{
    [Serializable]
    public class Response
    {
        public object Data { get; set; }
        public Result Result { get; set; }
        public string ErrorMessage { get; set; }
    }
    public enum Result
    {
        Basarili,
        Basarisiz
    }
}
