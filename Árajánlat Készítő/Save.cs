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
                    productsToFile[i] = products[i].Name;
                }
                File.WriteAllLines("Saves/products.txt", productsToFile);
                au?.Invoke();
            }
            else
            {
                string[] productsToFile = new string[products.Count];
                for (int i = 0; i < products.Count; i++)
                {
                    productsToFile[i] = products[i].Name;
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
                for (int i = 0; i < fileToList.Length; i++)
                {
                    products.Add(new Products(fileToList[i]));
                }
            }
            else
            {
                au?.Invoke();
            }
        }
    }
}
