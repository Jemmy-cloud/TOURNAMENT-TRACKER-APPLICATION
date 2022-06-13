using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void IntitializeConnections(DatabaseType db)
        {
       
            if (db == DatabaseType.Sql)
            {
                //Todo - SET UP SQL CONNECTOR PROPERLY
                SqlConnector sql = new SqlConnector();  
                Connection = sql ;
            }

            else if (db == DatabaseType.TextFile)
            {
                //Todo - Create Text Connection
                TextConnector text = new TextConnector();
                Connection = text ;
            }
        }
        public static string CnnString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

}
