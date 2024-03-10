using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DBMidProject
{
    class ConfigurationClass
    {
        String ConnectionStr = @"Data Source=DESKTOP-LHN00FL;Initial Catalog=ProjectB;Integrated Security=True";
        SqlConnection con;
        private static ConfigurationClass _instance;
        public static ConfigurationClass getInstance()
        {
            if (_instance == null)
                _instance = new ConfigurationClass();
            return _instance;
        }
        private ConfigurationClass()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}






