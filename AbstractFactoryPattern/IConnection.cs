using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IConnection
    {
        bool Connect();
        bool Disconnect();
        string State { get; }

    }
}
