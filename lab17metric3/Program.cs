using System;
using System.Linq;
using System.Collections.Generic;

namespace lab17
{

    class Program
    {
        static void Main()
        {
            int[] valuesOfEta2 = { 300, 400, 512 };
            int n = 5; // Число программистов
            int v = 20; // Число отлаженных в день команд ассемблера

            foreach (int eta_2 in valuesOfEta2)
            {
                int i = 0;
                double totalModules = 0;
                double k = eta_2 / 8;

                if (k > 8)
                {
                    i = 1;
                    while (k > 8)
                    {
                        k /= 8;
                        i++;
                    }
                    totalModules = k * Math.Pow(8, i);
                }
                else
                {
                    totalModules = eta_2;
                }

                double N = Math.Pow(2, totalModules);
                double V = N * eta_2;
                double P = N * Math.Log(eta_2, 2) / 8;

                double Tk = V / (n * v);
                double tau = 0.5 * Tk;
                double B = tau / Tk;

                double t_n = Math.Exp(-B);

                Console.WriteLine($"Метрические характеристики для eta_2 = {eta_2}:");
                Console.WriteLine($"Число уровней иерархии: {i}");
                Console.WriteLine($"Общее число модулей в ПС: {Math.Round(totalModules,2)}");
                Console.WriteLine($"Длина N программы: {Math.Round(N,2)}");
                Console.WriteLine($"Объем V ПС: {Math.Round(V,2)}");
                Console.WriteLine($"Длина ПС в количестве команд ассемблера P: {Math.Round(P,2)}");
                Console.WriteLine($"Календарное время программирования Tk: {Math.Round(Tk,2)}");
                Console.WriteLine($"Начальное количество ошибок B: {Math.Round(B,2)}");
                Console.WriteLine($"Начальная надежность ПС tн: {Math.Round(t_n,2)}");
                Console.WriteLine();
            }
        }
    }




}
