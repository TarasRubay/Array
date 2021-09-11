using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    struct task4
    {
        public void task_4()
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
            for (int i = 0; i < a.Length; ++i)
            {
                if (b.Length == 0)
                {
                    System.Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = a[i];
                }
                else if (!b.Contains(a[i]))
                {
                    System.Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = a[i];
                }
            }
            foreach (int _it in b)
                Console.Write($"{_it} ");
            Console.WriteLine();
            int sum = 0;
            foreach (int _it in b)
            {
                int f = 0;
                foreach (int _ij in a)
                    if (_it == _ij) f++;
                if (f == 1)
                {
                    sum++;
                }
            }
                    Console.Write($"sum numbers in array  == 1 times: {sum}\n");

        }
    }
}
