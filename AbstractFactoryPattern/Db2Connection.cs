using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Db2Connection : IConnection
    {
        public string State => "Open";

        public bool Connect()
        {
            Console.WriteLine("Db2 bağlantısı açılacak");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine("Db2 bağlantısı kapatılacak");
            return true;
        }
    }
}
