using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testinis
{
    class Program
    {
        static void Main()
        {
            int psk = Max(10, 20, 5);
            Console.WriteLine(psk);
            Console.ReadKey();


        }
        static int Max(int psk, int ask, int tsk)
        {
            if (psk >= ask && psk >= tsk)
            {
                return psk;
            }
            else if (ask >= tsk)
            {
                return ask;
            }
            else
            {
                return tsk;
            }

        }

    }

}
