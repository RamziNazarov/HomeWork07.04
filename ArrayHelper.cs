using System;

namespace HomeWork._07._04
{
    //В классе 4 метода с 5 перегрузками в каждом
    static class ArrayHelper
    {
        /// <summary>
        /// Удаляет послдений элемент массива и возвращает удаленный элемент используя return
        /// </summary>
        /// <param name="array">Массив последний элемент которого удаляем</param>
        /// <returns></returns>
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
        /// <summary>
        /// Добавляет элемент в конец массива и возвращает обновленную длину массива
        /// </summary>
        /// <param name="array">Массив в конец которого добавляем передаваемый элемент</param>
        /// <param name="el">Элемент который добавляется в конец передаваемого массива</param>
        /// <returns></returns>
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
        /// <summary>
        /// Удаляет первый элемент массива и возвращает этот удаленный элемент используя return, дял этого внутри 
        /// </summary>
        /// <param name="array">Массив первый элемент которого удаляем</param>
        /// <returns></returns>
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
        /// <summary>
        /// Добавляет элемент в начало массива и возвращает обновленную длину массива
        /// </summary>
        /// <param name="array">Массив в начало которого добавляем передаваемый элемент</param>
        /// <param name="el">Элемент который добавится в начале передаваемого массива</param>
        /// <returns></returns>
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