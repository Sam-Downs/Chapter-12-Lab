using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
     public class Item
    {
        private string _name;
        private string _upc;
        private decimal _price;
        private string _accessKey;
        private int _unitsPerCase;
        private decimal _costPerCase;
        private string _distributor;

        public Item(string name, string upc, decimal price, int unitsPerCase, decimal costPerCase, string distributor)
        {
            _name = name;
            _upc = upc;
            _price = price;
            _unitsPerCase = unitsPerCase;
            _costPerCase = costPerCase;
            _distributor = distributor;
        }

       public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string UPC
        {
            get { return _upc; }
            set { _upc = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int UnitsPerCase
        {
            get { return _unitsPerCase; }
            set { _unitsPerCase = value; }
        }
        public decimal CostPerCase
        {
            get { return _costPerCase; }
            set { _costPerCase = value; }
        }
        public string Distributor
        {
            get { return _distributor; }
            set { _distributor = value; }
        }



    }
}
