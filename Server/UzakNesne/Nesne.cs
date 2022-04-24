using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzakNesne
{
    public class Nesne:MarshalByRefObject
    {
        public string IsimVer()
        {
            return "Abdullah Usame Gundesli";
        }
        public string KucukHarfCevir(string str)
        {
            return str.ToLower();
        }
        public string BuyukHarfCevir(string str)
        {
            return str.ToUpper();
        }
        public string TersCevir(string str)
        {
            string strYeni = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strYeni += str[i];
            }
            return strYeni;
        }
    }
}
