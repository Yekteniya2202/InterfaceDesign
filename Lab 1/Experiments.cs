using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Experiments
    {
        public static class Exp1
        {
            public static int[] S = new int[] {0, 20, 40, 60, 100, 150, 200, 250, 300, 350};
            public static int D = default;
            public static long[,] t = new long[10,5];
            public static int[] misses = new int[10];
        }
        public static class Exp2    
        {
            public static int S = default;
            public static int[] D = new int[] { 8, 10, 12, 15, 20, 30, 50, 70, 100 };
            public static long[,] t = new long[9, 5];
            public static int[] misses = new int[9];
        }
        public static class Exp3
        {
            public static int[] S = new int[] { 0, 20, 40, 60, 100, 150, 200, 250, 300, 350 };
            public static int[] D = new int[] { 8, 10, 12, 15, 20, 30, 50, 70, 100 };
            public static long[,,] t = new long[9, 10, 3];
            public static int[,] misses = new int[9, 10];
        }
    }
}
