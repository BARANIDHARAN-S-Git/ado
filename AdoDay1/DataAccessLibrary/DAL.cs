using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace DataAccessLibrary
{
    public class DAL
    {
        public List<product_detail> ShowAllProducts()
        {
            string connectionString = "Data Source=LAPTOP-1GKJ0ROI\\SQLEXPRESS02;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);

            //SqlCommand cmd = new SqlCommand("create view productview as select ProductId,ProductName,UnitPrice from products", cn);
            //SqlCommand cmd = new SqlCommand("select * from products  ", cn);
            SqlCommand cmd = new SqlCommand("select * from productview  ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            List<product_detail> Products = new List<product_detail>();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    product_detail Details = new product_detail();
                    Details.Product_id = Convert.ToInt32(dr[0]);
                    Details.ProductName = dr[1].ToString();
                    Details.UnitPrice=Convert.ToDouble(dr[2]);
                    Products.Add(Details);
                    
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
            cn.Close();
            return Products;

        }

    }
}
