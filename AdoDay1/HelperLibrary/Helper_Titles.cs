using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using DataAccessLibrary;


namespace HelperLibrary
{
    public class Helper_Titles
    {
        public List<product_detail> Get_Titles()
        {
            DAL titles = new DAL();
            List<product_detail> ProductsList = new List<product_detail>();
            ProductsList = titles.ShowAllProducts();
            return ProductsList;


        }

    }
}
