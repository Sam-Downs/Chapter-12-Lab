using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        Item[] items = new Item[20];
        public Form1()
        {
            InitializeComponent();

            items[0] = new Item("Bottle Rocket", "1234-5678", 15m, "1234", 50, 100m, "Black Cat");
            items[1] = new Item("Rogue Wave", "8765-4321", 35m, "4321", 30, 550m, "Edgeclub");
            items[2] = new Item("Dixie Redneck", "1122-3344", 20m, "1020", 25, 400m, "Brainverse");
            items[3] = new Item("Waterfall", "1029-3847", 10m, "2938", 30, 250m, "Photobean");
            items[4] = new Item("Feel the Heat", "3948-5764", 50m,"9999", 10, 400m, "Feedfire");


        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = txtSearchByName.Text;

            
        }

        private void btnCodeSearch_Click(object sender, EventArgs e)
        {
            string codeSearch = txtSearchByCode.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal newPrice = decimal.Parse(txtUpdatePrice.Text);
            string accessKey = txtUpdateAccessKey.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string verifyUPC = txtDeleteCode.Text;
            string accessKey = txtDeleteKey.Text;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string nameAdd = txtAddName.Text;
            string codeAdd = txtAddCode.Text;
            decimal priceAdd = decimal.Parse(txtAddPrice.Text);
            string accessKey = txtAddKey.Text;
            decimal addCostPerCase = decimal.Parse(txtAddCost.Text);
            int addUnitsPerCase = int.Parse(txtAddUnits.Text);
            string distributor = txtAddDistributor.Text;

            Item newItems = new Item(nameAdd, codeAdd, priceAdd, accessKey, addUnitsPerCase, addCostPerCase, distributor);




        }
    }
}
