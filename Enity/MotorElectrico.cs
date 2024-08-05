using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enity
{
    public class MotorElectrico
    {
        bool conectado;
        bool activo;
        bool moviendo;

        public void Conectar()
        {
            conectado = false;
            Console.WriteLine("Motor electrico conectado!");
        }

        public void Activar()
        {
            activo = true;
            Console.WriteLine("Motor electrico activado!");
        }

        public void Mover()
        {
            moviendo= true;
            Console.WriteLine("Moviendo auto electrico!");
        }

        public void Parar()
        {
            moviendo = false;
            Console.WriteLine("Deteniendo auto electrico!");
        }

        public void Desactivar()
        {
            activo = false;
            Console.WriteLine("Motor electrico desactivado!");
        }
        public void Desconectar()
        {
            conectado = false;
            Console.WriteLine("Motor electrico desconectado!");
        }

        public void Enchufar()
        {
            if (activo)
            {
                Console.WriteLine("No se puede enchufar un vehiculo electrico activado");
            }
            else
            {
                Console.WriteLine("Motor electrico enchufado y cargando...!");
            }
        }
    }
}
