#define DEBUG_ACCOUNT
//Добавление дерективы предпроцессора
using System;
using System.Reflection;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tExercise 14.1 ");

            Account account = new Account(TypeAccount.accountCurrent, 2040000);
            account.Withdraw(4234);
            //Метод сработает, так как есть директива предпрцесса #define DEBUG_ACCOUNT
            account.DumpToScreen();
            Console.WriteLine();
            /*Упражнение 14.2 смотреть класс Rational.cs*/
            Console.WriteLine("\tHome Exercise 14.1 ");
            //Применение рефлексии для обращения к метаданным класса "Building"
            MemberInfo typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach(object attrObj in attrs)
            {
                if (attrObj is DeveloperInfo2Attribute attr)
                {
                    Console.WriteLine($"The developer of class \"Building\"  -- {attr.NameDeveloper}");
                    Console.WriteLine($"The organization  -- {attr.NameOrganization}");
                }
            }
            Console.ReadKey();
        }
    }
}
