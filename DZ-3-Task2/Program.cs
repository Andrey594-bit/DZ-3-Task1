using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА 1
            Console.WriteLine("Задача 1");
            Console.WriteLine("Введите 10 чисел:");

            int[] massiv = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Число " + (i + 1) + ": ");
                massiv[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool vozrastaet = true;
            int nomerNarusheniya = 0;

            for (int i = 0; i < 9; i++)
            {
                if (massiv[i] >= massiv[i + 1])
                {
                    vozrastaet = false;
                    nomerNarusheniya = i + 2;
                    break;
                }
            }

            if (vozrastaet == true)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine("Последовательность НЕ упорядочена.");
                Console.WriteLine("Первое число, которое нарушает порядок, стоит на месте: " + nomerNarusheniya);
            }

            Console.WriteLine();


            // ЗАДАЧА 2
            Console.WriteLine("Задача 2");
            Console.WriteLine("Введите номер карты от 6 до 14:");

            try
            {
                string vvod = Console.ReadLine();
                int nomerKarty = Convert.ToInt32(vvod);

                if (nomerKarty < 6 || nomerKarty > 14)
                {
                    Console.WriteLine("Ошибка: число должно быть от 6 до 14!");
                }
                else
                {
                    switch (nomerKarty)
                    {
                        case 11:
                            Console.WriteLine("Достоинство: Валет");
                            break;
                        case 12:
                            Console.WriteLine("Достоинство: Дама");
                            break;
                        case 13:
                            Console.WriteLine("Достоинство: Король");
                            break;
                        case 14:
                            Console.WriteLine("Достоинство: Туз");
                            break;
                        default:
                            Console.WriteLine("Достоинство: " + nomerKarty);
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: вы ввели не число!");
            }
            finally
            {
                Console.WriteLine("Проверка карты завершена.");
            }

            Console.WriteLine();


            // ЗАДАЧА 3
            Console.WriteLine("Задача 3");
            Console.WriteLine("Введите вашу профессию:");

            string professiya = Console.ReadLine();
            string professiyaMal = professiya.ToLower();
            string napitok = "";

            switch (professiyaMal)
            {
                case "jabroni":
                    napitok = "Patron Tequila";
                    break;
                case "school counselor":
                    napitok = "Anything with Alcohol";
                    break;
                case "programmer":
                    napitok = "Hipster Craft Beer";
                    break;
                case "bike gang member":
                    napitok = "Moonshine";
                    break;
                case "politician":
                    napitok = "Your tax dollars";
                    break;
                case "rapper":
                    napitok = "Cristal";
                    break;
                default:
                    napitok = "Beer";
                    break;
            }

            Console.WriteLine("Ваш напиток: " + napitok);

            Console.WriteLine();// ЗАДАЧА 4
            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите номер дня недели от 1 до 7:");

            int den = Convert.ToInt32(Console.ReadLine());

            switch (den)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Нет такого дня недели!");
                    break;
            }

            Console.WriteLine();


            // ЗАДАЧА 5
            Console.WriteLine("Задача 5");

            string[] igrushki = { "Car", "Hello Kitty", "Lego", "Barbie doll", "Ball", "Hello Kitty" };
            int kolichestvoKukol = 0;

            foreach (string igrushka in igrushki)
            {
                if (igrushka == "Hello Kitty" || igrushka == "Barbie doll")
                {
                    kolichestvoKukol = kolichestvoKukol + 1;
                }
            }

            Console.WriteLine("Кукол в сумке: " + kolichestvoKukol);

            Console.ReadLine();
        }
    }
}
