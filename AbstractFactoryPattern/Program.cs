using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();

            Factory db2Factory = new Factory(new Db2Factory());
            db2Factory.Start();
        }
    }
}
