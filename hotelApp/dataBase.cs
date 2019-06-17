using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelApp
{
    class dataBase
    {
        private string conStr = ConfigurationManager.ConnectionStrings["hotelApp"].ToString();

        public String query2Columnas(String query)
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
                        resultado += reader.GetValue(0)+" "+ reader.GetValue(1)+"\n";
                        
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return resultado;
        }

        public String query3Columnas(String query)
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
                        resultado += reader.GetValue(0) + "_" + reader.GetValue(1) + "_" + reader.GetValue(2)+ "\n";

                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return resultado;
        }

        public String query4Columnas(String query)
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
                        resultado += reader.GetValue(0) + "_" + reader.GetValue(1) + "_" + reader.GetValue(2)+ "_" + reader.GetValue(3) + "\n";

                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return resultado;
        }

        public String query1Columna(String query)
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
                        resultado += reader.GetValue(0)+" ";

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
