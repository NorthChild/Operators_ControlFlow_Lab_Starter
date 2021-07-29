using System;
using System.Collections.Generic;

namespace OperatorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 5;

            //int a = x++;
            //int b = ++y;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for (int i = 0; i <= 5; i++) {

            //    Console.WriteLine(i);
            //}

            //var c = 5 / 2;
            //var d = 5.0 / 2;
            //var e = 5 / 3;

            //double f = 5 / 2;

            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);


            //var daysInAWeek = 7;
            //var totalDaysToBirthday = 23;
            //var weeksToBirthday = totalDaysToBirthday / daysInAWeek;
            //var days = totalDaysToBirthday % daysInAWeek;

            //var res = EvenOdd(23);
            //Console.WriteLine(res);

            //const int NUM_ROWS = 2;
            //const int NUM_COLS = 5;
            //bool running = true;
            //int row = 0;
            //int col = 0;
            //int spriteNo = -1;


            //while (running)
            //{
            //    spriteNo = ++spriteNo % (NUM_ROWS * NUM_COLS);
            //    row = spriteNo / NUM_COLS;
            //    col = spriteNo / NUM_COLS;

            //}

            //List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };


            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));






        }

        

        //public static bool EvenOdd(int num) {

        //    return num % 2 == 0;

        //}





    }
}
