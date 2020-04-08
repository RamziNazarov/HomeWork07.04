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
        public static int Push (ref string[] array,string el)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = el;
            return array.Length;
        }
        public static int Push (ref int[] array,int el)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = el;
            return array.Length;
        }
        public static int Push (ref double[] array,double el)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = el;
            return array.Length;
        }
        public static int Push (ref decimal[] array,decimal el)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = el;
            return array.Length;
        }
        public static int Push (ref float[] array,float el)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = el;
            return array.Length;
        }
        public static string Shift (ref string[] array)
        {
            Array.Reverse(array);
            string arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            Array.Reverse(array);
            return arr;
        }
        public static int Shift (ref int[] array)
        {
            Array.Reverse(array);
            int arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            Array.Reverse(array);
            return arr;
        }
        public static double Shift (ref double[] array)
        {
            Array.Reverse(array);
            double arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            Array.Reverse(array);
            return arr;
        }
        public static decimal Shift (ref decimal[] array)
        {
            Array.Reverse(array);
            decimal arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            Array.Reverse(array);
            return arr;
        }
        public static float Shift (ref float[] array)
        {
            Array.Reverse(array);
            float arr = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            Array.Reverse(array);
            return arr;
        }
        public static int UnShift (ref string[] array,string el)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length-1);
            array[array.Length-1] = el;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref int[] array,int el)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length-1);
            array[array.Length-1] = el;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref double[] array,double el)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length-1);
            array[array.Length-1] = el;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref decimal[] array,decimal el)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length-1);
            array[array.Length-1] = el;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift (ref float[] array,float el)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length-1);
            array[array.Length-1] = el;
            Array.Reverse(array);
            return array.Length;
        }
    }
}