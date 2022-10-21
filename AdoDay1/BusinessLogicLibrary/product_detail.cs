using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class product_detail
    {
        

        private int _productid;
        public int Product_id
        {
            get
            {
                return _productid;
            }
            set
            {

                if (value.ToString().Length > 5)
                {
                    throw new Exception("Product id not valid");

                }
                else
                {
                    _productid = value;
                }
            }
        }



        private string _Productname;

        public string ProductName
        {
            get { return _Productname; }
            set
            {
                if ((value.Length > 80) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid Product.... Please check");
                }
                else
                {
                    _Productname = value;
                }

            }
        }
        
        private double _unitprice;
        public double UnitPrice
        {
            get { return _unitprice; }

            set
            {
                if(value.ToString().Length>7)
                {
                    throw new Exception("Unit Price is Not Valid");
                }

                else
                {
                    _unitprice = value;
                }
            }
        }


    }
}
