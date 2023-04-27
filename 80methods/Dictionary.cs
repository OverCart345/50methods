using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class Dictry
    {

        private enum Alpha { m1, m2, m3, m4, m5, m6,m7, exit };
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;


        Dictionary<int,int> dict;

        public Dictry()
        {


            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Add ";
            button_Name[1] = " ContainsKey ";
            button_Name[2] = " ContainsValue ";
            button_Name[3] = " Remove ";
            button_Name[4] = " Keys ";
            button_Name[5] = " Values ";
            button_Name[6] = " Clear ";
            button_Name[7] = " Назад ";


        }

        public void ini()
        {
            current_Button = (int)Alpha.m1;
            Choise();
        }

        private void Start()
        {
            Console.Clear();


            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Методы для Dictionary!");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("");
            int down = 4;

            for (int i = 0; i < button_count; i++)
            {

                int centerX = 3;
                int centerY = down;

                int eValue = (int)current_Button;

                Console.SetCursorPosition(centerX, centerY);
                if (eValue == i)
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.White,
                    Console.ForegroundColor = ConsoleColor.Black);
                }
                else
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.Black,
                    Console.ForegroundColor = ConsoleColor.White);
                }

                down += 2;
            }
            Console.ResetColor();
        }

        private void before()
        {
            dict = new Dictionary<int, int>();

            dict.Add(0, 1);
            dict.Add(1, 3);
            dict.Add(2, 9);
            dict.Add(3, 2);


            Console.SetCursorPosition(2, 1);
            Console.Write($"{button_Name[Convert.ToInt32(current_Button)]}");
            Console.SetCursorPosition(2, 2);
            Console.Write($"Ключи Dictionary:    ");
            foreach (var v in dict.Keys)
            {
                Console.Write($"{v} ");
            }

            Console.SetCursorPosition(2, 3);
            Console.Write($"Значения Dictionary: ");
            foreach (var v in dict.Values)
            {
                Console.Write($"{v} ");
            }

        }

        private void cont(int down)
        {
            Console.SetCursorPosition(3, down);
            Console.WriteLine(" Для продолжение нажмите на любую кнопку ", Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);

            Console.ReadKey();
            Console.ResetColor();
            Choise();
        }

        private void meth1()
        {
            Console.Clear();

            before();
            int down = 5;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите ключ: ");
            int a = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите значение: ");
            int b = int.Parse(Console.ReadLine());

            dict.Add(a,b);

            Console.SetCursorPosition(2, down++);
            Console.Write($"После Add(int,int) такой: ");
            Console.SetCursorPosition(2, down++);
            Console.Write($"Ключи Dictionary:    ");
            foreach (var v in dict.Keys)
            {
                Console.Write($"{v} ");
            }
            Console.SetCursorPosition(2, down++);
            Console.Write($"Значения Dictionary: ");
            foreach (var v in dict.Values)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth2()
        {
            Console.Clear();

            before();

            int down = 5;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите ключ: ");
            int a = int.Parse(Console.ReadLine());

            

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после ContainsKey(int): ");          
            Console.Write(dict.ContainsKey(a));
            

            cont(++down);
        }

        private void meth3()
        {
            Console.Clear();

            before();

            int down = 5;


            Console.SetCursorPosition(2, down++);
            Console.Write("Введите значение: ");
            int a = int.Parse(Console.ReadLine());



            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после ContainsValue(int): ");
            Console.Write(dict.ContainsValue(a));



            cont(++down);
        }

        private void meth4()
        {
            Console.Clear();

            before();

            int down = 5;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите ключ: ");
            int a = int.Parse(Console.ReadLine());

            dict.Remove(a);


            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Remove(int): ");

            Console.SetCursorPosition(2, down++);
            Console.Write($"Ключи Dictionary:    ");
            foreach (var v in dict.Keys)
            {
                Console.Write($"{v} ");
            }
            Console.SetCursorPosition(2, down++);
            Console.Write($"Значения Dictionary: ");
            foreach (var v in dict.Values)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth5()
        {
            Console.Clear();

            before();

            int down = 5;



            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Keys: ");
            foreach (var v in dict.Keys)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

        private void meth6()
        {
            Console.Clear();

            before();

            int down = 5;

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Values: ");
            foreach (var v in dict.Values)
            {
                Console.Write($"{v} ");
            }


            cont(++down);
        }

        private void meth7()
        {
            Console.Clear();

            before();

            int down = 5;

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Clear(): ");
            dict.Clear();
            
            Console.SetCursorPosition(2, down++);
            Console.Write($"Ключи Dictionary:    ");
            foreach (var v in dict.Keys)
            {
                Console.Write($"{v} ");
            }
            Console.SetCursorPosition(2, down++);
            Console.Write($"Значения Dictionary: ");
            foreach (var v in dict.Values)
            {
                Console.Write($"{v} ");
            }

            cont(++down);
        }

       

        private void Choise()
        {
            Start();
            ConsoleKeyInfo chose_Button;

            Console.ResetColor();
            do
            {
                chose_Button = Console.ReadKey();

                if (chose_Button.Key == ConsoleKey.UpArrow)
                {

                    if (current_Button > 0)
                    {
                        current_Button--;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.DownArrow)
                {
                    if ((int)current_Button < button_count - 1)
                    {
                        current_Button++;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.Enter)
                {

                    switch (current_Button)
                    {
                        case Alpha.m1: meth1(); break;
                        case Alpha.m2: meth2(); break;
                        case Alpha.m3: meth3(); break;
                        case Alpha.m4: meth4(); break;
                        case Alpha.m5: meth5(); break;
                        case Alpha.m6: meth6(); break;
                        case Alpha.m7: meth7(); break;

                        case Alpha.exit: Controller.switch_to_Main(); break;
                    }
                }



            } while (chose_Button.Key != ConsoleKey.Escape);

        }

    }
}
