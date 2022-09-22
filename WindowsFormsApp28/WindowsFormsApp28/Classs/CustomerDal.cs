using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp28.Classs
{
    
    public class CustomerDal
    {
        public static string connectionstring { get; set; }

        public static bool ControlCardCode(string cardcode)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("select * from Customer where card_code=@cardcode", connection);
            command.Parameters.AddWithValue("@cardcode", cardcode);
            SqlDataReader datareader;

            connection.Open();
            datareader = command.ExecuteReader();

            return datareader.Read();
            connection.Close();
        }

        public static bool ControlPassaword(string passaword, string cardcode)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("select * from Customer where card_code=@cardcode and  passaword=@passaword", connection);
            command.Parameters.AddWithValue("@cardcode", cardcode);
            command.Parameters.AddWithValue("@passaword", passaword);
            connection.Open();
            SqlDataReader dataread = command.ExecuteReader();

            return dataread.Read();
            connection.Close();

        }

        public static bool AmountQuery(Customer customer)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("select * from Customer where card_code=@cardcode and balance>=@balance", connection);
            command.Parameters.AddWithValue("@cardcode", customer.CardCode);
            command.Parameters.AddWithValue("@balance", customer.Balance);
            connection.Open();
            SqlDataReader dataread = command.ExecuteReader();


            return dataread.Read();

            connection.Close();


        }

        public static void BalanceUpdate(Customer customer, decimal amount)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("update Customer set balance=(select balance from Customer where card_code=@cardcode)-@amount where card_code=@cardcode", connection);
            command.Parameters.AddWithValue("@cardcode", customer.CardCode);
            command.Parameters.AddWithValue("@amount", amount);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }



        public static void ABalanceUpdate(Customer customer, decimal amount)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("update Customer set balance=((select balance from Customer where card_code=@cardcode)-@amount) where card_code=@cardcode", connection);
            command.Parameters.AddWithValue("@cardcode", customer.CardCode);
            command.Parameters.AddWithValue("@amount", amount);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static bool AcountQuery(string acountnumber)
        {
            bool bol;
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("select * from Acount where Number=@number",connection);
            command.Parameters.AddWithValue("@number", acountnumber);
            connection.Open();
            SqlDataReader datareader = command.ExecuteReader();
            
            bol = datareader.Read();
            connection.Close();

            return bol;
            
        }
          public static  void BalanceUpdateAcountCon(string acount , decimal amount)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("update Customer set balance=((select balance from Customer where  id=(select Id from Acount where Number=@acount))+@amount ) where id=(select Id from Acount where Number=@acount) ", connection);
            command.Parameters.AddWithValue("@acount", acount);
            command.Parameters.AddWithValue("@amount", amount);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static decimal GetBalance(Customer customer)
        {

            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("select balance from Customer where  card_code=@cardcode", connection);
            command.Parameters.AddWithValue("@cardcode", customer.CardCode);
            connection.Open();
            int amount = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return amount;
        }
    }






}
