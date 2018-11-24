using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Desarrollo
    {
        // Declaracion de variables
        int H;
        double[] V;
        // Creacion de listas
        List<double> Valores1 = new List<double>
        {
            11,2,3,14,18,4,5,-3,-1,6,9
        };
        List<double> Valores2 = new List<double>
        {
            1,3,5,7,8,3,9,0.7071,16.5664,12,0,10
        };
        List<double> Valores3 = new List<double>
        {
            3,7,15,1.3333,155,100,15,1.7320,5,-5,3,2
        };
        List<double> Valores4 = new List<double>
        {
            8,19,7,3,15,23,34,27,89,101
        };
        // Metodo donde se llenan las listas 
        public void Llenar(double N,int p)
        
        {
            H = Convert.ToInt32(N);
            V = new double[H];
            if (p==1)
            {
                for (int I = 1; I <= N; I++)
            {
                Console.Write("INGRESA EL VALOR SIGUIENTE ({0}) : ", Valores1[I - 1]);
                V[I - 1] = double.Parse(Console.ReadLine());

            }  
            }
            if (p==2)
            {
                  for (int I = 1; I <= N; I++)
            {
                Console.Write("INGRESA EL VALOR SIGUIENTE ({0}) : ", Valores2[I - 1]);
                V[I - 1] = double.Parse(Console.ReadLine());

            }
            }
            if (p==3)
            {
                for (int I = 1; I <= N; I++)
            {
                Console.Write("INGRESA EL VALOR SIGUIENTE ({0}) : ", Valores3[I - 1]);
                V[I - 1] = double.Parse(Console.ReadLine());

            }  
            }
            if (p==4)
            {
               for (int I = 1; I <= N; I++)
            {
                Console.Write("INGRESA EL VALOR SIGUIENTE ({0}) : ", Valores4[I - 1]);
                V[I - 1] = double.Parse(Console.ReadLine());

            }   
            }

            
            METODOQUICK(V, 0, N - 1);
            // Imprecion 
            Mostrar();


        }
        // desarrollo del metoo Quicksort
        private void METODOQUICK(double[] V, double P, double U)
        {
            int I, J, C;
            double PIVOTE;
            C = Convert.ToInt32((P + U) / 2);
            PIVOTE = V[C];
            I = Convert.ToInt32(P);
            J = Convert.ToInt32(U);

            do
            {
                while (V[I] < PIVOTE) I++;
                while (V[J] > PIVOTE) J--;

                if (I <= J)
                {
                    double TEMP;
                    TEMP = V[I];
                    V[I] = V[J];
                    V[J] = TEMP;
                    I++;
                    J--;

                }
            } while (I <= J);

            if (P < J)
            {
                METODOQUICK(V, P, J);
            }
            if (I < U)
            {
                METODOQUICK(V, I, U);
            }


        }

        // Metodo donde se desarrolla la imprecion del metodo ya ordenado 
        private void Mostrar()
        {
            Console.WriteLine("VECTOR ORDENADO");

            for (int I = 0; I < H; I++)
            {


                Console.Write(" " + V[I] + " ");
            }


            Console.ReadLine();
        }
    }
}
