using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCruid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9EJ59KT;Initial Catalog=EgitimKampiDB;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO Tbl_Category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi");
            #endregion

            #region Ürün Ekleme
            //string productName;
            //string productPrice;


            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9EJ59KT;Initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //Console.Write("Ürün Eklemesi Yapıldı");
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9EJ59KT;Initial Catalog=EgitimKampiDB;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.WriteLine("Silinecek Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9EJ59KT;Initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductID = @productId", connection);
            //cmd.Parameters.AddWithValue("@productId",productId);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı");
            #endregion

            #region Ürün Güncelle İşlemi
            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncelleneck Ürün Fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9EJ59KT;Initial Catalog=EgitimKampiDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductID=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Güncelleme Başarılı");
            #endregion

            Console.Read();

        }
    }
}
