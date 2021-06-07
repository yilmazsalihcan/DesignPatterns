using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new BMWBuilder();
            bmw.SetModel("320")
                .SetKm(1000)
                .SetGear(6)
                .SetBrand("X50");

            var bmwBuilder = bmw.Build();
          
        }
    }
}
