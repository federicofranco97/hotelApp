using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace hotelApp
{
    class dataBase
    {
        private string conStr = ConfigurationManager.ConnectionStrings["hotelApp"].ToString();

        public String queryConRespuesta(String query)
        {
            String resultado = "";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {

                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return resultado;
        }

        public void querySinRespuesta(String query)
        {
            using (SqlConnection connection = new SqlConnection(
               conStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public dataBase() { }
    }
}
