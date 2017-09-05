using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rectangulo = new Rectangulo();
            Triangulo triangulo = new Triangulo();


            rectangulo.Area(10,19);
            triangulo.Area(10,19);

            Console.ReadKey();
        }
 

    }

 }

