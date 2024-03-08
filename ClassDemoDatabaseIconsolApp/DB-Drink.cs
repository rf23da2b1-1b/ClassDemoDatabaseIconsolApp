using ClassDemoDatabaseIconsolApp.model;
using Microsoft.Data.SqlClient;

namespace ClassDemoDatabaseIconsolApp
{
    public class DB_Drink
    {
        private const string ConnectionString =
            "...connection-string";



        public List<Drink> GetAll()
        {
            List<Drink> drinks = new List<Drink>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            String sql = "select * from Drink";
            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Drink drink = ReadDrink(reader);
                drinks.Add(drink);
            }

            connection.Close();
            return drinks;
        }

        private Drink ReadDrink(SqlDataReader reader)
        {
            Drink drink = new Drink();

            drink.Id = reader.GetInt32(0);
            drink.Name = reader.GetString(1);
            drink.Alk = reader.GetBoolean(2);


            return drink;
        }


        private const String insertSql = "insert into Drink values(@name,@alc)";
        public void Add(Drink drink)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(insertSql, connection);
            cmd.Parameters.AddWithValue("@name", drink.Name);
            cmd.Parameters.AddWithValue("@alc", drink.Alk);

            int row = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows affected " + row);


            connection.Close();

        }
    }
}
