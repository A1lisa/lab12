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

            int[] grades= new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("введите оценку ученика " + (i + 1) + ": ");
                int grade = int.Parse(Console.ReadLine());
                while (grade < 2 || grade > 5)
                {
                    Console.WriteLine("Оценка должна быть от 2 до 5");
                    grade = int.Parse(Console.ReadLine());
                }
                grades[i] = grade;
            }

            var result = Logic.Grade(grades);

            Console.WriteLine("Пятерок: "+result[3]);
            Console.WriteLine("Четверок: " + result[2]);
            Console.WriteLine("Троек: " + result[1]);
            Console.WriteLine("Двоек: "+ result[0]);
        }
    }
}

public class Logic
{
    public static int[] Grade(int[] grades)
    {
        int count2 = 0, count3 = 0, count4 = 0, count5 = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            switch (grades[i])
            {
                case 5: count5++; break;
                case 4: count4++; break;
                case 3: count3++; break;
                case 2: count2++; break;
            }
        }
        return new int[] { count2, count3, count4, count5 };
    }
}
