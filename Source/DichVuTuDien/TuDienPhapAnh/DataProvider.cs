using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TuDienPhapAnh;

namespace TuDienPhapViet
{
    public class DataProvider
    {
        // ADO.NET
        private string connectionString = "Data Source=.;Initial Catalog=TuDienPhapAnh;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        // list of word
        private Word[] dict = new Word[100];

        public DataProvider()
        {
            GetData();
        }

        public void GetData()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM dict";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                Word word =  new Word(reader.GetString(0), reader.GetString(1));
                if (word != null)
                {
                    dict[i] = word;
                }
                i++;
            }

            connection.Close();
        }

        public string GetMean(string fr)
        {
            string en = "not found!";
            foreach (Word word in dict)
            {
                if (fr == word.fr)
                    return word.en;
            }
            return en;
        }
    }
}