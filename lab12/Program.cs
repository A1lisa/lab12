using System.ComponentModel;
using System.Net.Http.Headers;

namespace lab12
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите количество учеников");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Введите положительное число");
                n = int.Parse(Console.ReadLine());
            }

            int count2 = 0, count3 = 0, count4 = 0, count5 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("введите оценку ученика " + (i + 1) + ": ");
               int grades = int.Parse(Console.ReadLine());
               switch (grades)
                {
                    case 5: count5++; break;
                    case 4: count4++; break;
                    case 3: count3++; break;
                    case 2: count2++; break;
                    default: Console.WriteLine("Оценка должна быть от 2 до 5"); i--; break;
                }

            }

            Console.WriteLine("Пятерок: "+count5);
            Console.WriteLine("Четверок: " + count4);
            Console.WriteLine("Троек: " + count3);
            Console.WriteLine("Двоек: "+ count2);
        }
    }
}
