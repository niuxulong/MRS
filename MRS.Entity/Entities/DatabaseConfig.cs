using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Entity.Entities
{
    public class DatabaseConfig
    {
        public string Server { get; set; }

        public string Database { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public static DatabaseConfig FromString(string connString)
        {
            try
            {
                var tempArr = connString.Split(new char[] { ';' });
                var config = new DatabaseConfig()
                {
                    Server = tempArr[0].Split(new char[] { '=' })[1],
                    Database = tempArr[1].Split(new char[] { '=' })[1],
                    User = tempArr[2].Split(new char[] { '=' })[1],
                    Password = tempArr[3].Split(new char[] { '=' })[1],
                };
                return config;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
