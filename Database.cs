using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.Utility
{
    internal class Database
    {
        public static string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";

        public static string GetConnectionString()
        {
            return connection;
        }
    }
}
