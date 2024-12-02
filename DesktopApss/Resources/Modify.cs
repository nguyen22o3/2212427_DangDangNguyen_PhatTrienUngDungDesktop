using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApss.Resources
{
    class Modify
    {
        public Modify() { }
        public List<Account> Accounts (string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = Utilities.GetSql())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    accounts.Add(new Account(reader.GetString(0),reader.GetString(1),reader.GetInt32(2)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }
    }
}
