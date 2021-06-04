using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Db2Factory : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new Db2Command();
        }

        public IConnection CreateConnection()
        {
            return new Db2Connection();
        }
    }
}
