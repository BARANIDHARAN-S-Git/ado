using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
using HelperLibrary;



namespace AdoDay1
{
    
     class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Helper_Titles titles = new Helper_Titles();

                List<product_detail> books = new List<product_detail>();

                books = titles.Get_Titles();

                foreach (var item in books)
                {
                    Console.WriteLine("Product Id : "+item.Product_id);
                    Console.WriteLine("Product Name : "+item.ProductName);
                    Console.WriteLine("Unit Price : "+item.UnitPrice);
                    Console.WriteLine(" ");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.Read();






        }
    }
}
