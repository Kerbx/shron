using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kurwaconsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // Первый файл.
            // Задание 1.
            /*
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string birthDate = Console.ReadLine();
            string adress = Console.ReadLine();
            string country = Console.ReadLine();
            char gender = (char)Console.Read();

            string kurs = "Разработка программных модулей.";
            double result = 100.00f;
            int zanyatiya = 3;
            string prepod = "Жукова М.А.";

            Console.WriteLine($"Информация о студенте:\nИмя: {name};\nФамилия: {surname};\nДата рождения: {birthDate};\nАдрес: {adress};\nПол: {gender};\nСтрана: {country};\nИнформация о курсе:\nНазвание курса: {kurs};\nБаллы: {result};\nКоличество занятий в неделю: {zanyatiya};\nПреподаватель: {prepod}\n");
            Console.ReadKey();
            */

            // Задание 2
            /*
            int firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());
            double avg = (firstNumber + secondNumber) / 2;
            Console.WriteLine(avg);
            Console.ReadKey();
            */

            // Задание 3
            /*
            Console.WriteLine("Введите сторону треугольника:\n");
            double strona = int.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(3);

            Console.WriteLine($"Периметр: {strona * 3}");
            Console.WriteLine($"Площадь: {(Math.Pow(strona, 2.0f) * sqrt) / 4  }");
            Console.ReadKey();
            */

            // Задание 4
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a < b && b < c);
            Console.ReadKey();
            */

            // Задание 5
            /*
            Console.WriteLine("Введите четыре числа:\n");
            int x1= int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());

            Console.WriteLine(x1 + x2 > x3 + x4);
            Console.ReadKey();
            */

            // Второй файл.
            // Задание 1
            /*
            Console.WriteLine("Введите число:\n");
            int num = int.Parse(Console.ReadLine());

            if(num >= 0)
            {
                Console.WriteLine("Введенное число положительное.");
            }
            else
            {
                Console.WriteLine("Введенное число отрицательное.");
            }

            Console.ReadKey();
            */

            // Задание 2
            /*
            Console.WriteLine("Введите двузначное число.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Десятки: {Math.Abs(num) / 10}; единицы: {Math.Abs(num) % 10};");
            Console.ReadKey();
            */

            // Задание 3
            /*
            Console.WriteLine("Введите трехзначное число.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num / 100}0{num % 10}");
            Console.ReadKey();
            */

            // Задание 4
            /*
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());

            if(x1 != x2 || x1 != x3 || x2 != x3)
            {
                Console.WriteLine("true.");
            }
            else
            {
                Console.WriteLine("false.");
            }
            */

            // Задание 5
            /*
            Console.WriteLine("Введите три числа:\n");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a)
            {
                double halfPer = (a + b + c) / 2;
                double sqrt = Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
                Console.WriteLine($"Такой треугольник существует, его площадь: {sqrt}");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует.");
            }
            */

            // Задание 6
            /*
            Console.WriteLine("Введите x:\n");
            int x = int.Parse(Console.ReadLine());

            if(x < -2 || x > 2)
            {
                Console.WriteLine($"Значение функции равно: {2 * x}");
            }
            else
            {
                Console.WriteLine($"Значение функции равно: {-3 * x}");
            }
            */

            // Задание 7
            /*
            Console.WriteLine("Введите число:\n");
            double x = double.Parse(Console.ReadLine());

            if(x > 0)
            {
                Console.WriteLine($"Значение функции равно: {2 * Math.Sin(x)}");
            }
            else
            {
                Console.WriteLine($"Значение функции равно: {6 - x}");
            }
            */

            // Задание 8
            /*
            Console.WriteLine("Возможные порции:\n1 - small\n2 - medium\n3 - large\n");
            int size = int.Parse(Console.ReadLine());
            string result = "";

            switch (size)
            {
                case 1:
                    result = "Понедельник";
                    break;
                case 2:
                    result = "Вторник";
                    break;
                case 3:
                    result = "Среда";
                    break;
                case 4:
                    result = "Четверг";
                    break;
                case 5:
                    result = "Пятница";
                    break;
                case 6:
                    result = "Суббота";
                    break;
                case 7:
                    result = "Воскресенье";
                    break;
                default:
                    Console.WriteLine("Такого дня нет.");
                    break;
            }

            Console.WriteLine($"Результат: {size}-й день недели - {result}");
            */

            // Файл 3
            // Задание 1
            /*

            for(int i = -3; i <= 24; i += 3)
            {
                Console.WriteLine($"{i} ");
            }
            */

            // Задание 2
            /*
            for(int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
            for(int i = 99; i >=1; i--)
            {
                Console.Write($"{i} ");
            }
            */

            // Задание 3
            /*
            int negative = 0;
            int positive = 0;

            for(int i = 0; i < 10; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if(temp > 0)
                {
                    positive++;
                }
                else if(temp < 0)
                {
                    negative++;
                }
            }

            Console.WriteLine($"Количество положительных чисел: {positive}\nКоличество отрицательных чисел: {negative}");
            */

            // Задание 4
            /*
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Сумма введенных чисел равна: {sum}");
            */

            // Задание 5
            /*
            int sum = 0;

            for(int i = 1; i < 19; i += 2)
            {
                sum += i;
                Console.Write($"{i} + ");
            }

            Console.Write($"=> Сумма = {sum}");
            */

            // Задание 6
            /*
            double power = 0.0f;

            for(int i = 0; i < 10; i++)
            {
                power *= double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Произведение чисел равно: {power}");
            */

            // Задание 7
            /*
            for(int i = 2; i < 8; i++)
            {
                for(double pow = 2.0f; i < 5; i++)
                {
                    Console.WriteLine($"z(x,y) = {i} ^ {pow} = {Math.Pow(i, pow)}");
                }
            }
            */

            // Задание 8
            /*
            for(int i = 30; i < 30; i++)
            {
                for(int y = 1; y < 5; y++)
                {
                    Console.WriteLine($"z(x,y) = {i} - {y} = {i - y}");
                }
            }
            */

            // Файл 4
            // Задание 1
            /*
            int counter1 = 3;
            while (counter1 <= 21)
            {
                Console.Write($"{counter1} ");
                counter1 += 2;
            }

            int counter2 = 3;
            do
            {
                Console.Write($"{counter2} ");
                counter2 += 2;
            } while (counter2 <= 21);
            */

            // Задание 2
            /*
            int counter1 = 15;
            while (counter1 <= 0)
            {
                Console.Write($"{counter1} ");
                counter1 -= 3;
            }

            int counter2 = 15;
            do
            {
                Console.Write($"{counter2} ");
                counter2 -= 3;
            } while (counter2 <= 0);
            */

            // Задание 3
            /*
            int product = 10;
            int power = 1;

            while(product <= 20)
            {
                power *= product;
                Console.Write($"{product} * ");
                product += 2;
            }
            Console.Write($"= {power}");
            */

            // Задание 4
            /*
            double sum = 0;
            int counter = 1;

            while(counter <= 5)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                counter++;
            }

            Console.WriteLine($"Сумма введенных чисел равна: {sum}");
            */

            // Задание 5
            /*
            int counter = 1;
            int maximum = 0;
            int prev = 0;

            do
            {
                maximum = int.Parse(Console.ReadLine());
                if (maximum > prev)
                {
                    prev = maximum;
                    counter++;  
                }
            } while (maximum != 0);

            Console.WriteLine($"Максимальное число {prev}, его порядковый номер {counter}");
            */
        }
    }
}

