using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    public delegate double OperaGX(double x, double y);
    internal class Menu
    {
        private enum Alpha { sum, sub, mul, buul,puck, exit};
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;



        public Menu()
        {


            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Stack ";
            button_Name[1] = " Queue ";
            button_Name[2] = " Dictionary ";
            button_Name[3] = " List ";
            button_Name[4] = " SortedList ";
            button_Name[5] = " Выход ";
        }

        public void ini()
        {
            current_Button = (int)Alpha.sum;
            Choise();
        }

        private void Start()
        {
            Console.Clear();

            int down = button_count;

            for (int i = 0; i < button_count; i++)
            {

                int centerX = (Console.WindowWidth / 2) - (button_Name[i].Length / 2);
                int centerY = (Console.WindowHeight / 2) - down;

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

                down -= 2;
            }
            Console.ResetColor();
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
                        case Alpha.sum: Controller.switch_to_ArrList(); break;
                        case Alpha.sub: Controller.switch_to_HashTable(); break;
                        case Alpha.mul: Controller.switch_to_Arr(); break;
                        case Alpha.buul: Controller.switch_to_Listik(); break;
                        case Alpha.puck: Controller.switch_to_SList(); break;
                        case Alpha.exit: Environment.Exit(1); break;
                    }
                }



            } while (chose_Button.Key != ConsoleKey.Escape);

        }


    }
}
