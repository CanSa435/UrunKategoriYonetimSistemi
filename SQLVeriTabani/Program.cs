using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLVeriTabani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.NET

            Console.WriteLine("***** C# VERİ TABANLI ÜRÜN KATEGORİ BİLGİ SİSTEMİ *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9EJ59KT;Initial Catalog=EgitimKampiDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Tbl_Category",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
