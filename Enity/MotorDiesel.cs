using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enity
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando vehiculo a diesel!");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando vehiculo a diesel!");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando combustible al vehiculo a diesel!");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo vehiculo a diesel!");
        }
    }
}
