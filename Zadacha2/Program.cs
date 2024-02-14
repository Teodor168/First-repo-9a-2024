using System.Diagnostics.CodeAnalysis;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Da se vuvede n za broqt na elementite v masiv
            //Da se deklarira masiv ot celi chisla
            //Da se vuvedat vsichki elementi na masiva
            //Da se otpechati sumata ot vsichki elementi
            //Srednoto aretmeticno na elementite
            //Nai golemiqt element ot masiva i na koe mqsto e
            Console.WriteLine("Dai chislo");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($" array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //sumata
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine($"Sum={sum}");

            //min
            int min = int.MaxValue;
            int minPos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];
                minPos = i;
            }
            Console.WriteLine($"{min}===>{minPos}");


            // qko print
            for (int i = 0; i < array.Length ; i++)
            {
                Console.WriteLine($" array[{i}] = {array[i]}");

            }

        }
    }
}
