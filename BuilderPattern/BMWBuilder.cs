using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BMWBuilder : ICarBuilder
    {
        private Car _car;
        public BMWBuilder()
        {
            _car = new Car();
        }
        public ICarBuilder SetBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public ICarBuilder SetGear(int gear)
        {
            _car.Gear = gear;
            return this;
        }

        public ICarBuilder SetKm(decimal km)
        {
            _car.Km = km;
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public Car Build() => _car;
    }
}
