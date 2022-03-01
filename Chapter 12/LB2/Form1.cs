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
        public Form1()
        {
            InitializeComponent();
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




        }
    }
}
