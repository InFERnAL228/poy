using System;//Библиотека
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2//Название проекта
{
    class Program//Класс
    {
        static void Main()//Метод Main
        {
            double m;//Объявляем переменную
            double cm;
            double mm;
            double d;
            Console.WriteLine("Введите число дюймов:");//Вводим данные в консоль
            d = Convert.ToDouble(Console.ReadLine()); //Конвертируем
            cm = 2.54 * d;//Находим см
            mm = 2.54 * d * 10;//Находим мм
            m = 2.54 * d / 100; //Находим м
            Console.WriteLine(" {0} м, {1} см, {2} мм", m, cm, mm);//Выоводим результат
            Console.ReadKey();//Задержка экрана 
        }
    }
}