using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            
            string signZodiac;
            Console.Write("Введите ваш знак зодиака: ");
            signZodiac = Console.ReadLine();
            
            string work;
            Console.Write("Ваше место работы: ");
            work = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age}, ваш знак зодиака {signZodiac}" +
                $" и вы работаете {work}.");

        }
    }
}
