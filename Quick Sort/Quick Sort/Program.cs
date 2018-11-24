using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Console.Title = "METODO QUICKSORT";
        perro:
            Console.Clear();
            // Menu
            Console.WriteLine(@"Seleccione el ejercicio
1.- ejercicio 1
2.- ejercicio2
3.- ejercicio3
4.- ejercicio4
5.- salir");
            // Menu ya desarrollado 
            int a = int.Parse(Console.ReadLine());
            if (a==1)
            {
              Desarrollo OBJ = new Desarrollo();
            OBJ.Llenar(11,1);
            Console.WriteLine("Teclee cualquier tecla");
                Console.ReadKey();
                goto perro;
            }
            if (a == 2)
            {
                Desarrollo ON = new Desarrollo();
                ON.Llenar(12,2);
                Console.WriteLine("Teclee cualquier tecla");
                Console.ReadKey();
                goto perro;
            }
            if (a==3)
            {
              Desarrollo O = new Desarrollo();
            O.Llenar(12,3);
            Console.WriteLine("Teclee cualquier tecla");
            Console.ReadKey();
            goto perro;
            }
            if (a==4)
            {
             Desarrollo A = new Desarrollo();
            A.Llenar(10,4);
            Console.WriteLine("Teclee cualquier tecla");
            Console.ReadKey();
            goto perro;
            }
            if (a==5)
            {
                Console.WriteLine("Teclee cualquier tecla");
                Console.ReadKey();  
            }


            Console.ReadKey();
        }
    }
}
