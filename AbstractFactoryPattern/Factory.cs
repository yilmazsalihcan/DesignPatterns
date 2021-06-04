using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Factory
    {
        private IDatabaseFactory _databaseFactory;
        private IConnection _connection;
        private ICommand _command;

        public Factory(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();
            if (_connection.State == "Open")
            {
                _command.Execute("Select * from");
            }
        }
    }
}
