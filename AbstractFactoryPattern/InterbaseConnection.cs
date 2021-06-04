using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class InterbaseConnection : IConnection
    {
        public string State => "Open";

        public bool Connect()
        {
            Console.WriteLine("Interbase bağlantısı açılacak");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine("Interbase bağlantısı kapatılacak");
            return true;
        }
    }
}
