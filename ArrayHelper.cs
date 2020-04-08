using System;
namespace HomeWork._07._04
{
    static class ArrayHelper
    {
        public static string Pop (ref string[] array)
        {
            string arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        public static int Pop (ref int[] array)
        {
            int arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        public static double Pop (ref double[] array)
        {
            double arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        public static decimal Pop (ref decimal[] array)
        {
            decimal arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
        public static float Pop (ref float[] array)
        {
            float arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return arr;
        }
    }
}