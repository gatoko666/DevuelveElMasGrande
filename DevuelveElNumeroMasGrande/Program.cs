using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10) Escribir un método que acepte una lista de números y devuelva el número más grande.


namespace DevuelveElNumeroMasGrande
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {

                        int ma = 0, me = 0, num = 0;
                        Console.WriteLine("Cuántos números va ingresar : ");
                        int numeros = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= numeros; i++)
                        {
                            Console.WriteLine("Digite un número: ");
                            num = int.Parse(Console.ReadLine());

                            if (i == 1)
                            {
                                ma = num;
                                me = num;
                            }
                            if (num > ma) { ma = num; }
                            if (num < me) { me = num; }
                            num = 0;
                        }

                        Console.WriteLine(" numero mayor es: " + ma);
                        Console.WriteLine(" numero menor es: " + me);
                        Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escribe algún valor válido");
                }

            }
           
        }
    }
}
