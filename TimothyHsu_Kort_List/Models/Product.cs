using System.Text;
using TimothyHsu_Kort_List.Interfaces;

namespace TimothyHsu_Kort_List.Models
{
    public class Product:IProduct
    {
        public string Merk { get; set; }
        public string Naam { get; set; }
        public string Volume { get; set; }
        public string GetCode()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Merk.Substring(0,3).ToUpper());
            stringBuilder.Append(Naam.Substring(0,3).ToUpper());
            stringBuilder.Append(Volume.Replace(' ','_'));
            return stringBuilder.ToString();
        }
    }
}
