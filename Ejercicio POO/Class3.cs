using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO
{
    using System;

    internal class Apartamento : Casa
    {
        public Apartamento() : base(50)
        {
        }

        public new void MostrarDatos()
        {
            Console.WriteLine($"Soy un Apartamento, mi área es {Area} m2.");
        }
    }

}
