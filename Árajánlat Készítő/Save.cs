using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Árajánlat_Készítő
{
    public delegate void AskUser();

    class Save
    {
        public void SaveProducts(List<Products> products, AskUser au)
        {
            if (!Directory.Exists("Saves"))
            {
                Directory.CreateDirectory("Saves");

                string[] productsToFile = new string[products.Count];
                for (int i = 0; i < products.Count; i++)
                {
                    productsToFile[i] = products[i].Name + ";" + products[i].ReturnString();
                }
                File.WriteAllLines("Saves/products.txt", productsToFile);
                au?.Invoke();
            }
            else
            {
                string[] productsToFile = new string[products.Count];
                for (int i = 0; i < products.Count; i++)
                {
                    productsToFile[i] = products[i].Name + ";" + products[i].ReturnString();
                }
                File.WriteAllLines("Saves/products.txt", productsToFile);
                au?.Invoke();
            }

        }

        public void RetrieveProducts(List<Products> products, AskUser au)
        {
            if (File.Exists("Saves/products.txt"))
            {
                string[] fileToList = new string[File.ReadAllLines("Saves/products.txt").Length];
                fileToList = File.ReadAllLines("Saves/products.txt");

                Products boolInput = new Products(null, false);
                string load;
                for (int i = 0; i < fileToList.Length; i++)
                {
                    load = fileToList[i].Split(';')[1];
                    products.Add(new Products(fileToList[i].Split(';')[0], boolInput.StringToBool(load)));
                }
            }
            else
            {
                au?.Invoke();
            }
        }
    }
}

