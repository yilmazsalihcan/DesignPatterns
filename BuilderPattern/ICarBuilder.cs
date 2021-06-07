using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICarBuilder
    {
        ICarBuilder SetBrand(string brand);
        ICarBuilder SetModel(string model);
        ICarBuilder SetKm(decimal km);
        ICarBuilder SetGear(int gear);
    }
}
