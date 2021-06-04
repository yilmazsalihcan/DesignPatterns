using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{

    public interface IScreen
    {
        void Draw();
    }

    public class WinScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Windows ekranı...");
        }
    }

    public class WebScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Web ekranı...");
        }
    }

    public class MobileScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Mobile ekranı...");
        }
    }
}
