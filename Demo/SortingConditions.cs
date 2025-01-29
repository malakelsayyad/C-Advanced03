using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingConditions
    {
        public static bool CompareAscending(int X, int Y) { return X > Y; }
        public static bool CompareDescending(int X, int Y) { return X < Y; }

        public static bool CompareAscending(string X, string Y) { return X.Length > Y.Length; }
        public static bool CompareDescending(string X, string Y) { return X.Length < Y.Length; }
    }
}
