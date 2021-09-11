using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    struct task3
    {
        public void task_3()
        {
            int size_arr = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter size array");
                    size_arr = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    size_arr = -1;
                }
            } while (size_arr < 0);
            int[] a = new int[size_arr];

            Program.fill_arr(ref a);

            foreach (int _it in a)
                Console.Write($"{_it} ");
            Console.WriteLine();

            int[] b = new int[0];
            int from, to;
            do
            {
                try
                {
                    Console.WriteLine("Enter start range");
                    from = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    from = -1;
                }
            } while (from < 0);
            do
            {
                try
                {
                    Console.WriteLine("Enter end range");
                    to = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    to = -1;
                }
            } while (to < from);

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] >= from && a[i] <= to)
                {
                    System.Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = a[i];
                }
            }

            foreach (int _it in b)
                Console.Write($"{_it} ");
            Console.WriteLine();

        }
    }
}
