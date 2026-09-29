using System;

namespace LabWorkTumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Введите номер дня в году (от 1 до 365):");

            int denVGodu = Convert.ToInt32(Console.ReadLine());
            int mesyac = 1;
            int denVMesyace = denVGodu;

            int[] dneyVMesyacah = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < 12; i++)
            {
                if (denVMesyace > dneyVMesyacah[i])
                {
                    denVMesyace = denVMesyace - dneyVMesyacah[i];
                    mesyac = mesyac + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Месяц: " + mesyac);
            Console.WriteLine("День: " + denVMesyace);

            Console.WriteLine();


            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите номер дня в году (от 1 до 365):");

            try
            {
                int denVGodu2 = Convert.ToInt32(Console.ReadLine());

                if (denVGodu2 < 1 || denVGodu2 > 365)
                {
                    throw new Exception("Число должно быть от 1 до 365!");
                }

                int mesyac2 = 1;
                int denVMesyace2 = denVGodu2;
                int[] dneyVMesyacah2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                for (int i = 0; i < 12; i++)
                {
                    if (denVMesyace2 > dneyVMesyacah2[i])
                    {
                        denVMesyace2 = denVMesyace2 - dneyVMesyacah2[i];
                        mesyac2 = mesyac2 + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Месяц: " + mesyac2);
                Console.WriteLine("День: " + denVMesyace2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine();


            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Введите год:");
            int god = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня в году (от 1 до 365 или 366):");
            int denVGodu3 = Convert.ToInt32(Console.ReadLine());

            bool visokosny = false;

            if (god % 400 == 0)
            {
                visokosny = true;
            }
            else if (god % 100 == 0)
            {
                visokosny = false;
            }
            else if (god % 4 == 0)
            {
                visokosny = true;
            }
            else
            {
                visokosny = false;
            }

            if (visokosny == true)
            {
                Console.WriteLine("Год високосный!");
            }
            else
            {
                Console.WriteLine("Год не високосный.");
            }

            try
            {
                if (visokosny == true)
                {
                    if (denVGodu3 < 1 || denVGodu3 > 366)
                    {
                        throw new Exception("Число должно быть от 1 до 366!");
                    }
                }
                else
                {
                    if (denVGodu3 < 1 || denVGodu3 > 365)
                    {
                        throw new Exception("Число должно быть от 1 до 365!");
                    }
                }

                int mesyac3 = 1;
                int denVMesyace3 = denVGodu3;

                int[] dneyVMesyacah3 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (visokosny == true)
                {
                    dneyVMesyacah3[1] = 29;
                }

                for (int i = 0; i < 12; i++)
                {
                    if (denVMesyace3 > dneyVMesyacah3[i])
                    {
                        denVMesyace3 = denVMesyace3 - dneyVMesyacah3[i];
                        mesyac3 = mesyac3 + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Месяц: " + mesyac3);
                Console.WriteLine("День: " + denVMesyace3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
