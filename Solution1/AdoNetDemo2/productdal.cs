using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo2
{
    public class productdal
    {


        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog =ETrade;integrated security=true");
        public DataTable GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();


            }
        }


        public void Add(product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values (@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Update(product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Updates Products set Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount where Id = @id ", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            

            _connection.Close();

        }
    }
}
