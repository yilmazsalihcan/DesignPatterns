using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Db2Command : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine("Db2 Sorgusu çalıştırılır");
        }
    }
}
