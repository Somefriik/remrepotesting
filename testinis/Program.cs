﻿using System;
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
            //int pirm = Convert.ToInt32(Console.ReadLine());
            int Di = 0;

            /* Console.WriteLine(IsPrimal(13));
             Console.WriteLine(IsPrimal(12));*/
            Console.WriteLine(D20(Di));
            Console.ReadKey();
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
       private static bool IsPrimal(int pirm)
        {
           
            for(int i=2;i<pirm;i++)
            {
                if (pirm % i == 0) {
                    return false;
                }
               
            }
            return true;

        }
        private static int D20(int Di)
        {

            for (int DS = 0;)
            {
                if (Di > 0 && Di < 20)
                {
                    Console.WriteLine(Di);
                   
                }
                
                break;
            }
            return Di;

        }

    }

}
