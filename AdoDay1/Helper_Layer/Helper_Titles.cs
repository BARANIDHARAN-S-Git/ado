using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layer;
using DataAccessLayer;
namespace Helper_Layer
{
    public class Helper_Titles
    {
        public List<BL_Titles> Get_Titles()
        {
            using DAL_Titles titles = new DAL_Titles();
            List<BL_Titles> booksList = new List<BL_Titles>();
            booksList = titles.ShowAllBooks();
            return booksList;


        }
    }
}