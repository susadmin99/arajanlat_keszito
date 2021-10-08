using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Árajánlat_Készítő
{
    public partial class Form1 : Form
    {
        List<Products> products = new List<Products>();
        Save save = new Save();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCheckboxList(checkedListBox1, products);
        }


        private void AddNewElementBtn_Click(object sender, EventArgs e)
        {
            string newElementName = textBox1.Text.ToString();

            if (newElementName != null && newElementName != "")
            {
                products.Add(new Products(Name = newElementName));
                textBox1.Text = null;
                newElementName = null;

                LoadCheckboxList(checkedListBox1, products);
            }
            
        }

        private void LoadCheckboxList(CheckedListBox clb, List<Products> productsList)
        {
            clb.Items.Clear();
            foreach (var item in productsList)
            {
                clb.Items.Add(item.Name);
            }
        }

        private void ClearList(CheckedListBox clb, List<Products> productsList)
        {
            clb.Items.Clear();
            productsList.Clear();
        }

        private void AskUser_FileDoesNotExists()
        {
            MessageBox.Show("Nem sikerült a fájl beolvasása, mert nem található beolvasható 'termékek' fájl!", "Nem található fájl!", MessageBoxButtons.OK);
        }

        private void AskUser_SuccessfulSave()
        {
            MessageBox.Show("Fájl mentése sikeresen megtörtént!", "Fájl mentés", MessageBoxButtons.OK);
        }

        private void FileReadBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                save.RetrieveProducts(products, AskUser_FileDoesNotExists);
                LoadCheckboxList(checkedListBox1, products);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                DialogResult dr = MessageBox.Show("Biztos el akarod menteni a listát? \n A lista nem tartalmaz egyetlen terméket sem.", "Üres lista!", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        save.SaveProducts(products, AskUser_SuccessfulSave);
                        break;

                    case DialogResult.No:
                        break;

                    default:
                        break;
                }
            }
            else
            {
                save.SaveProducts(products, AskUser_SuccessfulSave);
            }
        }

        private void ClearListBtn_Click(object sender, EventArgs e)
        {
            ClearList(checkedListBox1, products);
        }
    }
}
