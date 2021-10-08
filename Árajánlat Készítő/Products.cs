using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árajánlat_Készítő
{
    class Products
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public Products(string name, bool isChecked)
        {
            this.Name = name;
            this.IsChecked = isChecked;
        }

        public string ReturnString()
        {
            if (IsChecked)
            {
                return "T";
            }
            else
            {
                return "F";
            }
        }

        public bool StringToBool(string sign)
        {
            switch (sign)
            {
                case "T":
                    return true;

                case "F":
                    return false;

                default:
                    return false;
            }
        }
    }
}
