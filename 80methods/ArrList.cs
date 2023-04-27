using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class Stacks
    {

        private enum Alpha { m1, m2, m3, m4,m5,exit};
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;


        Stack stack;

        public Stacks()
        {


            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Contains ";
            button_Name[1] = " Pop ";
            button_Name[2] = " Push ";
            button_Name[3] = " Peek ";
            button_Name[4] = " Clear ";
            button_Name[5] = " Назад ";


            
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
            Console.WriteLine("Методы для Stack!");
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
            stack = new Stack();

            stack.Push(2);
            stack.Push(6);
            stack.Push(1);
            stack.Push(3);
;

            Console.SetCursorPosition(2, 1);
            Console.Write($"{button_Name[Convert.ToInt32(current_Button)]}");
            Console.SetCursorPosition(2, 2);
            Console.Write($"Stack сейчас такой: ");
            foreach (var v in stack)
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

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите объект: ");
            int a = int.Parse(Console.ReadLine());           

            Console.SetCursorPosition(2, 4);
            Console.Write($"Результат после Contains(object): ");
            Console.Write(stack.Contains(a));

            cont(5);
        }

        private void meth2()
        {
            Console.Clear();

            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Pop(): ");
            Console.Write(stack.Pop());


            cont(++down);
        }

        private void meth3()
        {
            Console.Clear();

            before();

            int down = 4;

            Console.SetCursorPosition(2, down++);
            Console.Write("Введите Объект: ");
            int f = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, down++);
            Console.Write($"После Push(object) такой: ");
            stack.Push(f);
            foreach (var v in stack)
            {
                Console.Write($"{v} ");
            }


            cont(++down);
        }

        private void meth4()
        {
            Console.Clear();

            before();

            int down = 4;


            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Peek(): ");
            Console.Write(stack.Peek());

            cont(++down);
        }

        private void meth5()
        {
            Console.Clear();

            before();

            int down = 4;



            Console.SetCursorPosition(2, down++);
            Console.Write($"Результат после Clear(): ");
            stack.Clear();

            foreach (var v in stack)
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
                      

                        case Alpha.exit: Controller.switch_to_Main(); break;
                    }
                }



            } while (chose_Button.Key != ConsoleKey.Escape);

        }
    }
}
