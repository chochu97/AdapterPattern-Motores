using Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMotor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Motor nafta = new MotorNafta();
            nafta.Arrancar();
            nafta.Acelerar();
            nafta.Detener();

            Motor diesel = new MotorDiesel();
            diesel.Arrancar();
            diesel.Detener();

            Motor electrico = new MotorElectricoAdapter();
            electrico.Arrancar();
            electrico.CargarCombustible();
            electrico.Detener();
            electrico.CargarCombustible();

            Console.ReadKey();
        } 
    }
}
