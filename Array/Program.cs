using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int menu = 100, switch_on = menu, max_menu = 4;
            do
            {
                switch (switch_on)
                {
                    case 100:
                        do
                        {
                            Console.WriteLine("1 - Task 1");
                            Console.WriteLine("2 - Task 2");
                            Console.WriteLine("3 - Task 3");
                            Console.WriteLine("4 - Task 4");
                            //Console.WriteLine("5 - Task 5");
                            //Console.WriteLine("6 - Task 6");
                            //Console.WriteLine("7 - Task 7");
                            //Console.WriteLine("8 - Task 8");
                            //Console.WriteLine("9 - Task 9");
                            //Console.WriteLine("10 - Task 10");
                            Console.WriteLine("0 - exit");
                            try
                            {
                                switch_on = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception a)
                            {
                                Console.WriteLine(a.Message);
                            }
                        } while (switch_on < 0 || switch_on > max_menu);


                        break;
                    case 1:
                        Console.WriteLine("Task 1");
                        task1 t1;
                        t1.task_1();
                        switch_on = menu;
                        break;
                    case 2:
                        Console.WriteLine("Task 2");
                        task2 t2;
                        t2.task_2();
                        switch_on = menu;
                        break;
                    case 3:
                        Console.WriteLine("task 3");
                        task3 t3;
                        t3.task_3();
                        switch_on = menu;
                        break;
                    case 4:
                        Console.WriteLine("Task 4");
                        task4 t4;
                        t4.task_4();
                        switch_on = menu;
                        break;
                    case 5:
                        Console.WriteLine("Task 5");
                        
                        switch_on = menu;
                        break;
                    case 6:
                        Console.WriteLine("Task 6");
                        
                        switch_on = menu;
                        break;
                    case 7:
                        Console.WriteLine("Task 7");

                        switch_on = menu;
                        break;
                    case 8:
                        Console.WriteLine("Task 8");

                        switch_on = menu;
                        break;
                    case 9:
                        Console.WriteLine("Task 9");

                        switch_on = menu;
                        break;
                    case 10:
                        Console.WriteLine("Task 10");

                        switch_on = menu;
                        break;
                    default:
                        break;
                }

            } while (switch_on != 0);
        }
        
        public static void fill_arr(ref int[] _ar)
        {

            int r_start, r_end;
            do
            {
                try
                {
                    Console.WriteLine("Enter start range random");
                    r_start = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    r_start = -1;
                }
            } while (r_start < 0);
            do
            {
                try
                {
                    Console.WriteLine("Enter end range random");
                    r_end = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    r_end = -1;
                }
            } while (r_end < r_start);
            Random rnd = new Random();
            for (int i = 0; i < _ar.Length; ++i)
                _ar[i] = rnd.Next(r_start, r_end);
        }
    }
}
