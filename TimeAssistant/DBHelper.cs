using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace TimeAssistant
{
    public static class DBHelper
    {

        public static DataTable GetDataTable(string FilePath, string query)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = string.Format(@"Data Source={0};Version=3;Read Only=True;", FilePath);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con);
                DataTable table = new DataTable();

                // execute query as fast as possible in as mimimum as possible time
                con.Open();
                adapter.Fill(table);
                con.Close();

                return table;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
