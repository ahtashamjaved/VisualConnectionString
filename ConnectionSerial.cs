using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConnectionString
{
    [Serializable()]	//Set this attribute to all the classes that you define to be serialized
    public class ConnectionSerial
    {
        public string serverName { get; set; }
        public string databaseName { get; set; }
        public string Timeout { get; set; }
        public string integratedSecurity { get; set; }
        public string userName { get; set; }
        public string password { get; set; }


    }
}
