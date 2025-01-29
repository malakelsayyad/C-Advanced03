using System.Security.Cryptography.X509Certificates;

namespace Demo
{
   
    #region Delegate Ex01
    // Step01 : Create a new datatype (Delegate)

    public delegate int StringFunDelegate(string S);
    // New Delegate (Class): Reference can refer to function (Pointer of function )
    // Functions must have the same signature of the delegate int(string)
    // Regardless of Function name , Parameter name , Access modifiers 
    #endregion

    internal class Program
    {
        #region Delegate Ex02
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Delegate Ex03
        public static List<T> FindElement<T>(List<T> List, Func<T,bool> reference)
        {
            List<T> Result = new List<T>();

            if (List?.Count > 0)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    if (reference.Invoke(List[i]))
                        Result.Add(List[i]);
                }
            }

            return Result;
        }
        //public static List<int> FindElement(List<int> List, ConditionFunDelegate reference)
        //{
        //    List<int> Result = new List<int>();

        //    if (List?.Count > 0)
        //    {
        //        for (int i = 0; i < List.Count; i++)
        //        {
        //            if (reference.Invoke(List[i]))
        //                Result.Add(List[i]);
        //        }
        //    }

        //    return Result;
        //}

        //public static List<string> FindElement(List<string> List, ConditionFunDelegate02 reference)
        //{
        //    List<string> Result = new List<string>();

        //    if (List?.Count > 0)
        //    {
        //        for (int i = 0; i < List.Count; i++)
        //        {
        //            if (reference.Invoke(List[i]))
        //                Result.Add(List[i]);
        //        }
        //    }

        //    return Result;
        //}

        //public static List<int> FindOdd(List<int> List)
        //{
        //    List<int> Result = new List<int>();

        //    if (List?.Count>0) 
        //    {
        //        for (int i = 0;  i < List.Count;i++)
        //        {
        //            if (ConditionsFunctions.CheckOdd(List[i]))
        //                Result.Add(List[i]);
        //        }
        //    }

        //    return Result;
        //}

        //public static List<int> FindEven(List<int> List)
        //{
        //    List<int> Result = new List<int>();

        //    if (List?.Count > 0)
        //    {
        //        for (int i = 0; i < List.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckEven(List[i]))
        //                Result.Add(List[i]);
        //        }
        //    }

        //    return Result;
        //}

        //public static List<int> FindDivisibleByFour(List<int> List)
        //{
        //    List<int> Result = new List<int>();

        //    if (List?.Count > 0)
        //    {
        //        for (int i = 0; i < List.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckDivisibleByFour(List[i]))
        //                Result.Add(List[i]);
        //        }
        //    }

        //    return Result;
        //} 
        #endregion

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Delegate overview
            // Delegate : C# feature 
            // C# Pure OOP
            // Functional Paradigm
            // Event-Driven Paradigm

            // Java --> Pure OOP
            // Design Patterns  
            #endregion

            #region Delegate Ex01
            //Step02 : Use Delegate
            //StringFunDelegate X;
            //X= StringFunctions.GetCountOfUpperCase;

            //StringFunDelegate X= new StringFunDelegate(StringFunctions.GetCountOfUpperCase);

            //StringFunDelegate X = StringFunctions.GetCountOfUpperCase; //Syntax sugar

            //X += StringFunctions.GetCountOfLowerCase;

            //int count = X.Invoke("Hello World");
            //int count = X("Hello World");
            //Console.WriteLine(count); 
            #endregion

            #region Delegate Ex02

            //int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };

            //PrintArray(Numbers);

            //SortingAlgorithms.BubbleSortAscending(Numbers); // Ascending sorting
            //SortingAlgorithms.BubbleSortDescending(Numbers); // Ascending sorting

            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareAscending);
            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareDescending);

            //PrintArray(Numbers);

            //string[] Names = {"Ahmed","Ali","Mariam","Mahmoud","Amr","Mona","Khaled" };

            //PrintArray(Names);

            //SortingAlgorithms.BubbleSort(Names,SortingConditions.CompareDescending); // Ascending sorting

            //PrintArray(Names);


            #endregion

            #region Delegate Ex03

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = FindOdd(Numbers);
            //List<int> EvenNumbers = FindEven(Numbers);
            //List<int> DivisibleByFour = FindDivisibleByFour(Numbers);

            //List<int> OddNumbers = FindElement(Numbers, ConditionsFunctions.CheckOdd);
            //List<int> EvenNumbers = FindElement(Numbers, ConditionsFunctions.CheckEven);
            //List<int> DivisibleByFour = FindElement(Numbers, ConditionsFunctions.CheckDivisibleByFour);

            //PrintList(Numbers);

            //PrintList(OddNumbers);
            //PrintList(EvenNumbers);
            //PrintList(DivisibleByFour);

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mariam", "Mahmoud", "Amr", "Mona", "Khaled" };

            //List<string> GreaterThan4=FindElement(Names,ConditionsFunctions.GreaterThanFour);
            //List<string> LessThan4=FindElement(Names,ConditionsFunctions.LessThanFour);
            //List<string> Equals4=FindElement(Names,ConditionsFunctions.EqualFour);

            //PrintList(GreaterThan4);
            //PrintList(LessThan4);
            //PrintList(Equals4);

            #endregion

            #region Built-in Delegates
            // Predicate,Func,Action

            // Predicate 

            //ConditionFunDelegateGeneric<int> X = ConditionsFunctions.CheckEven;

            //Predicate<int> predicate = ConditionsFunctions.CheckEven;

            //bool result = predicate(1);
            //Console.WriteLine(result);

            //Func
            //Func<int> func = Fun01;
            //Func<int,string> func2 = Fun02;

            //Func<int,bool> predicate= ConditionsFunctions.CheckEven;

            //Action

            //Action<string> action = Print;
            //action.Invoke();
            //action(); 
            #endregion

            #region Anonymous Method and Lambda Expression 
            //Func<int, bool> func = ConditionsFunctions.CheckEven;
            //func(1);

            //List<int> Numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };

            //Anonymous Method
            //C# 2.0 2005

            //Func<int, bool> func = delegate (int X){ return X % 2 == 0; }; // Anonymous Method

            //FindElement(Numbers,func);     
            //FindElement(Numbers, delegate (int X) { return X % 2 == 0; });

            //Lambda Expression [Recommended]
            //C# 3.0 2007

            //FindElement(Numbers,func);     
            //FindElement(Numbers, delegate (int X) { return X % 2 == 0; });
            //Func<int, bool> func = X => X % 2 == 0;

            //FindElement(Numbers, N => N % 2 == 0);
            //FindElement(Numbers, N => N % 2 != 0);

            //Enumerable.Where(Numbers, ConditionsFunctions.CheckOdd);
            //Enumerable.Where(Numbers, delegate (int X) { return X % 2 == 0; });
            //Enumerable.Where(Numbers, X => X % 2 != 0);

            #endregion

            #region Var

            //C# Keyword
            //C# 3.0
            //var

            //var X = "hello";

            //var predicate = ConditionsFunctions.CheckDivisibleByFour;  
            #endregion

            #region Function returns function
            //var X = Fun01();
            //X.Invoke();
            //Fun01()(); 
            #endregion  

        }

        //public static Action Fun01() 
        //{
        //    //Action action = Print;
        //    //Action action = delegate (){ Console.WriteLine("Hello World"); };
        //    Action action = () => Console.WriteLine("Hello World");
        //    return action;

        //}
        //public static void Print() 
        //{
        //     Console.WriteLine("hello world"); 
        //}

        //public static void Print(string s)
        //{
        //    Console.WriteLine($"{s}");
        //}
        //public static int Fun01() { return 1; }
        //public static string Fun02(int X) { return $"{X}"; }

        
    }
}
