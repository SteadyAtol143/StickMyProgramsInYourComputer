using System;
using System.Net;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           input:
           Console.WriteLine("Введите зарплату работника за час(in the segment [100;1000]): ");
           string Salary = Console.ReadLine();
           Console.WriteLine("Введите количество работников на предприятии(in the segment [2;50]): ");
           string N = Console.ReadLine();
           Console.WriteLine("Введите количество рабочих часов в день(in the segement [3;12]):");
           string H = Console.ReadLine();

           int SalaryP = 0, NP = 0, HP = 0;
           if (!Int32.TryParse(Salary,out SalaryP) || !Int32.TryParse(N, out NP) || !Int32.TryParse(H, out HP))
           {
               Console.WriteLine("Вы что-то ввели не так!");
               goto input;
           }
           else
           {
               SalaryP = Int32.Parse(Salary);
               NP = Int32.Parse(N);
               HP = Int32.Parse(H);
               if ((SalaryP < 100 || SalaryP > 1000) || (NP < 2 || NP > 50) || (HP < 3 || HP > 12))
               {
                   Console.WriteLine("Вы ввели значение, которое не входит в область допустимых значений!");
               }
               else
               {
                   Console.WriteLine("Сумма зарплат всех работников за один день: {0} ",(NP * HP * SalaryP));
                   Console.WriteLine("Зарплата одного работника за месяц: {0}", (22*HP*SalaryP));
                   Console.WriteLine("Количество часов в неделю, которое отрабатывает один работник при 5-дневной рабочей неделе: {0}", (5*HP));
                   Console.WriteLine("Желаете ли (fisting) повторить процедуру? ");
                   Console.WriteLine("YES - если да, NO - если нет");
                   check:
                   string ChecInput = Console.ReadLine();
                   switch (ChecInput)
                   {
                       case "YES":
                           goto input;
                           break;
                       case "NO":
                           Console.WriteLine("До свидания!");
                           break;
                       default:
                           Console.WriteLine("Вы ввели какую-то поебень, попробуйте снова.");
                           goto check;
                   }
               }
           }

        }
    }
}
