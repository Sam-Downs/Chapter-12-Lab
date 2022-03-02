using System;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        Item[] items = new Item[20];
        int i;
        int itemsCreated;
        const string ACCESS_KEY = "1234";
        bool found;
        int location;
        public Form1()
        {
            InitializeComponent();

            items[0] = new Item("Bottle Rocket", "1234-5678", 15m, 50, 100m, "Black Cat");
            items[1] = new Item("Rogue Wave", "8765-4321", 35m, 30, 550m, "Edgeclub");
            items[2] = new Item("Dixie Redneck", "1122-3344", 20m, 25, 400m, "Brainverse");
            items[3] = new Item("Waterfall", "1029-3847", 10m, 30, 250m, "Photobean");
            items[4] = new Item("Feel the Heat", "3948-5764", 50m, 10, 400m, "Feedfire");
            itemsCreated = 4;
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = txtSearchByName.Text.ToLower();

            found = false;

            for (i = 0; i <= itemsCreated && found == false; i++)
            {
                if (items[i].Name.ToLower().Contains(nameSearch))
                {
                    found = true;
                    location = i;
                    DisplayItem(location);

                    break;
                }
            }
            ClearTextboxes();
        }

        private void btnCodeSearch_Click(object sender, EventArgs e)
        {
            string codeSearch = txtSearchByCode.Text.ToLower();
            found = false;

            for (i = 0; i <= itemsCreated && found == false; i++)
            {
                if (items[i].UPC.ToLower().Contains(codeSearch))
                {
                    found = true;
                    location = i;
                    DisplayItem(location);

                    break;
                }
            }
            ClearTextboxes();
        }

        private void DisplayItem(int location)
        {
            lblName.Text = items[location].Name.ToString();
            lblCode.Text = items[location].UPC.ToString();
            lblCostPerCase.Text = items[location].CostPerCase.ToString("c");
            lblDistributor.Text = items[location].Distributor.ToString();
            lblStorePrice.Text = items[location].Price.ToString("c");
            lblUnitsPerCase.Text = items[location].UnitsPerCase.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal newPrice = decimal.Parse(txtUpdatePrice.Text);
            string accessKey = txtUpdateAccessKey.Text;
            if (accessKey == ACCESS_KEY)
            {
               items[location].Price = newPrice;
            }
            else
            {
               lblErrorOne.Text = "Access Key Incorrect";
            }
            ClearTextboxes();
            DisplayItem(location);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string verifyUPC = txtDeleteCode.Text;
            string accessKey = txtDeleteKey.Text;
            for (i = 0; i <= itemsCreated; i++)
            {
                if (items[i].UPC.Equals(verifyUPC) && accessKey.Equals(ACCESS_KEY))
                {
                    itemsCreated = i;
                    itemsCreated--;
                    break;
                }
                else
                {
                    lblErrorTwo.Text = "Access Key Incorrect";
                }
            }
            ClearTextboxes();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string nameAdd = txtAddName.Text;
            string codeAdd = txtAddCode.Text;
            string accessKey = txtDeleteKey.Text;
            decimal priceAdd = decimal.Parse(txtAddPrice.Text);
            decimal addCostPerCase = decimal.Parse(txtAddCost.Text);
            int addUnitsPerCase = int.Parse(txtAddUnits.Text);
            string distributor = txtAddDistributor.Text;

            if (accessKey == ACCESS_KEY)
            {
                itemsCreated++;
                items[itemsCreated] = new Item(nameAdd, codeAdd, priceAdd, addUnitsPerCase, addCostPerCase, distributor);
                location = itemsCreated;
            } else lblErrorThree.Text = "Access Key Incorrect";

            ClearTextboxes();
        }

        private void ClearTextboxes()
        {
            txtAddName.Text = String.Empty;
            txtAddCode.Text = String.Empty;
            txtAddCost.Text = String.Empty;
            txtAddDistributor.Text = String.Empty;
            txtAddKey.Text = String.Empty;
            txtAddPrice.Text = String.Empty;
            txtAddUnits.Text = String.Empty;
        }
    }
}
