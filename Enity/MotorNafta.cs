using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enity
{
    public class MotorNafta : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando vehiculo a nafta!");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando vehiculo a nafta!");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargandole combustible al vehiculo a nafta!");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo vehiculo a nafta!");
        }
    }
}
