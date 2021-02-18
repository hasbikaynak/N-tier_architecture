using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_tier_architecture
{
     internal class DataAccessLayer
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public DataAccessLayer()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.; Initial Catalog = Adonet; User ID=sa; Password =1";
        }
       
        internal void ConnectionOptions()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            
                connection.Open();
            
            else
            
                connection.Close();
        }

        internal int SaveData(Costumer C)
        {
            //It is going to be saving to database proccess here
            return 1;
        }

    }

    
}
