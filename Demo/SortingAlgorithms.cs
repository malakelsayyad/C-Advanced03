using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool SortingFunDelegate(int A, int B);
    public delegate bool SortingFunDelegate02(string A, string B);

    //Generic Delegate
    public delegate bool SortingFunDelegateGeneric<T>(T A, T B);
    internal class SortingAlgorithms
    {
        public static void BubbleSort<T>(T[] Arr, Func<T,T,bool> reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        //public static void BubbleSort(int[] Arr, SortingFunDelegate reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j], Arr[j + 1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSort(string[] Arr, SortingFunDelegate02 reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j], Arr[j + 1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortAscending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingConditions.CompareAscending(Arr[j] , Arr[j + 1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingConditions.CompareDescending(Arr[j], Arr[j + 1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortAscending(int[] Arr)
        //{
        //    if (Arr?.Length>0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                  SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        //private static void SWAP(ref int X,ref int Y)
        //{ 
        //    int temp=X; 
        //    X=Y; 
        //    Y=temp;
        //}
        //private static void SWAP(ref string X, ref string Y)
        //{
        //    string temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        private static void SWAP<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
    }
}
