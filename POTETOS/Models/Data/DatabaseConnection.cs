using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTETOS.Models.Data
{
    class DatabaseConnection
    {
        private static DatabaseConnection _instance = null;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString = @"Data Source=ARMANDO28\SQLEXPRESS;Initial Catalog=POTETOS;Integrated Security=True;";
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new DatabaseConnection();
                    }
                }
                return _instance;
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }

}
