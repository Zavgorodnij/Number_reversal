using System;

namespace Kakaya_To_Xernia
{
    class Program
    {
        static int number1 = 0; static int number2 = 0; static int number3 = 0; static bool triger = false;
        static void Main(string[] args)
        {
            //Религия мне не позволяет использовать паскаль!
            //Даже ТА САМАЯ ЛЕРА ИЗ ИСОВ НЕ СМОЖЕТ ЕЁ СЛОМАТЬ!
            do
            {
                triger = false;
                try
                {
                    Console.Write("Введите первое число="); number1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите второе число="); number2 = int.Parse(Console.ReadLine());
                    Console.Write("Введите третье число="); number3 = int.Parse(Console.ReadLine());
                    if (number1<=0 || number2<=0 || number3<=0 || number1>=10 ||number2>=10 ||number3>=10) throw new FormatException("Введи нормальное число");
                }
                catch (System.ArgumentNullException e)
                {
                    Console.WriteLine("Баалляяяя!!! Мне больно!");
                    triger = true;
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Баалляяяя!!! Мне больно!");
                    triger = true;
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("Баалляяяя!!! Мне больно!");
                    triger = true;
                }
            } while (triger);
           
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine(number3 + number2 + number1);
        }
    }
}
