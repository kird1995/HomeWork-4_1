using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            int[] box = new int[random.Next(5, 50)]; 
            int maxInd = 0, minInd = 0;
            for(int i = 0; i < box.Length; i++)
                box[i] = random.Next(100, 400); 
            int min = box[0];
            int max = box[0];
            int avg = 0;
            for (int i = 0; i < box.Length; i++)
            {
                avg += box[i];
                if (box[i] < min)
                {
                    minInd = i;
                    min = box[i];
                }                  
                if (box[i] > max)
                {
                    maxInd = i;
                    max = box[i];
                }
                Console.WriteLine(box[i]);
            }
            avg /= box.Length;
            double minDif = max;
            int minDifInd = 0;
            for (int i = 0; i < box.Length; i++)
                if (box[i] < avg == 1)
                    double dif = avg - box[i];

            if (box[i] < avg == 1)

            Console.WriteLine($"{box[maxInd]} = {maxInd} {box[minInd]} = {minInd}");
            Console.ReadLine();



            


        }
    }
}
