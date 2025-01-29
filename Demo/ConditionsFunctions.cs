using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool ConditionFunDelegate(int A);
    public delegate bool ConditionFunDelegate02(string A);

    //Generic
    public delegate bool ConditionFunDelegateGeneric<T>(T A);

    internal class ConditionsFunctions
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivisibleByFour (int X) { return X % 4 == 0; }
        public static bool GreaterThanFour (string X) { return X.Length > 4; }
        public static bool LessThanFour (string X) { return X.Length < 4; }
        public static bool EqualFour (string X) { return X.Length == 4; }
    }
}
