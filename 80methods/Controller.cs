using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class Controller
    {

        static private Menu menu;
        static private Stacks stack;
        static private Dictry dictry;
        static private Queueueue queueueue;
        static private Listik listik;
        static private SortedLIST Slist;

        public Controller()
        {
            menu = new Menu();
            stack = new Stacks();
            dictry = new Dictry();
            queueueue = new Queueueue();
            listik = new Listik();
            Slist = new SortedLIST();

            switch_to_Main();
        }

        static public void switch_to_Main() { menu.ini(); }
        static public void switch_to_ArrList() { stack.ini(); }
        static public void switch_to_Arr() { dictry.ini(); }
        static public void switch_to_HashTable() { queueueue.ini(); }
        static public void switch_to_Listik() { listik.ini(); }
        static public void switch_to_SList() { Slist.ini(); }
    }
}
