using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp28
{
    class Zadanie23
    {
        static void Main(string[] args)
        {
               

            Console.WriteLine("Введите число: ");
            int v = Convert.ToInt32(Console.ReadLine());
            
            FactorAsync(v);
            
            Console.ReadKey();

        }
                                    static void Factor(int v)
                                    {
                                    int c = 1;
                                    for (int i = 1; i <= v; i++)
                                    {
                                    c = c*i;
                                    }
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Факториал числа равен {0}",c);
                                    }

                                            static async void FactorAsync(int v)
                                            {
                                            Console.WriteLine("Вызов FactorialAsync");
                                            await Task.Run(() => Factor(v));                
                                            Console.WriteLine("Окончен FactorialAsync");
                                            }
    }
}

