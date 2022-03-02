using System;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        Item[] items = new Item[20];

        int itemsCreated;
        public Form1()
        {
            InitializeComponent();

            items[0] = new Item("Bottle Rocket", "1234-5678", 15m, "1234", 50, 100m, "Black Cat");
            items[1] = new Item("Rogue Wave", "8765-4321", 35m, "4321", 30, 550m, "Edgeclub");
            items[2] = new Item("Dixie Redneck", "1122-3344", 20m, "1020", 25, 400m, "Brainverse");
            items[3] = new Item("Waterfall", "1029-3847", 10m, "2938", 30, 250m, "Photobean");
            items[4] = new Item("Feel the Heat", "3948-5764", 50m, "9999", 10, 400m, "Feedfire");
            itemsCreated = 4;




        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {


            string nameSearch = txtSearchByName.Text.ToLower();

            bool nameFound = false;

            for (int i = 0; i <= itemsCreated && nameFound == false; i++)
            {
                if (items[i].Name.ToLower().Contains(nameSearch))
                {
                    nameFound = true;
                    lblName.Text = items[i].Name.ToString();
                    lblCode.Text = items[i].UPC.ToString();
                    lblCostPerCase.Text = items[i].CostPerCase.ToString("c");
                    lblDistributor.Text = items[i].Distributor.ToString();
                    lblStorePrice.Text = items[i].Price.ToString("c");
                    lblUnitsPerCase.Text = items[i].UnitsPerCase.ToString();

                    break;
                }

            }
            ClearTextboxes();


        }

        private void btnCodeSearch_Click(object sender, EventArgs e)
        {




            string codeSearch = txtSearchByCode.Text.ToLower();



            bool codeFound = false;

            for (int i = 0; i <= itemsCreated && codeFound == false; i++)
            {
                if (items[i].UPC.ToLower().Contains(codeSearch))
                {
                    codeFound = true;
                    lblName.Text = items[i].Name.ToString();
                    lblCode.Text = items[i].UPC.ToString();
                    lblCostPerCase.Text = items[i].CostPerCase.ToString("c");
                    lblDistributor.Text = items[i].Distributor.ToString();
                    lblStorePrice.Text = items[i].Price.ToString("c");
                    lblUnitsPerCase.Text = items[i].UnitsPerCase.ToString();

                    break;
                }

            }
            ClearTextboxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            decimal newPrice = decimal.Parse(txtUpdatePrice.Text);
            string accessKey = txtUpdateAccessKey.Text;

            for (int i = 0; i <= itemsCreated; i++)
            {
                if (accessKey == items[i].AccessKey)
                {
                    items[i].Price = newPrice;

                   

                }
                else
                {
                    lblErrorOne.Text = "Access Key Incorrect";
                }
            }
            ClearTextboxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            string verifyUPC = txtDeleteCode.Text;
            string accessKey = txtDeleteKey.Text;

            for (int i = 0; i <= itemsCreated; i++)
            {
                if (items[i].UPC.Equals(verifyUPC) && items[i].AccessKey.Equals(accessKey))
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
            decimal priceAdd = decimal.Parse(txtAddPrice.Text);
            string accessKey = txtAddKey.Text;
            decimal addCostPerCase = decimal.Parse(txtAddCost.Text);
            int addUnitsPerCase = int.Parse(txtAddUnits.Text);
            string distributor = txtAddDistributor.Text;

            itemsCreated++;
            items[itemsCreated] = new Item(nameAdd, codeAdd, priceAdd, accessKey, addUnitsPerCase, addCostPerCase, distributor);

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
