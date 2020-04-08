using System;

namespace HomeWork._07._04
{
    class Program
    {
        static void WriteArray (string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                System.Console.Write(i == array.Length-1?array[i] + "\n":array[i] + " - ");
            }
        }
        static void Main(string[] args)
        {
            string[] arrayOfNames = {"Ramz","Amirbek","Husnoro","Zulaykho","Ilhom"};
            string nameForAdd = "";
            System.Console.Write("Массив имен с которым будем работать: ");
            WriteArray(arrayOfNames);
            System.Console.WriteLine("Исходная длина массива: " + arrayOfNames.Length);
            nameForAdd = ArrayHelper.Pop(ref arrayOfNames);
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("Удаляем последний элемент массива используя метод Pop.");
            WriteArray(arrayOfNames);
            System.Console.WriteLine("Длина массива после использования метода Pop: " + arrayOfNames.Length);
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("Добавляем удаленный элемент в конец массива используя метод Push.");
            ArrayHelper.Push(ref arrayOfNames,nameForAdd);
            WriteArray(arrayOfNames);
            System.Console.WriteLine("Длина массива после использования метода Push: " + arrayOfNames.Length);
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("Удаляем первый элемент массива используя метод Shift.");
            nameForAdd = ArrayHelper.Shift(ref arrayOfNames);
            WriteArray(arrayOfNames);
            System.Console.WriteLine("Длина массива после использования метода Shift: " + arrayOfNames.Length);
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("Добавляем удаленный элемент в начало массива используя метод UnShift.");
            ArrayHelper.UnShift(ref arrayOfNames,nameForAdd);
            WriteArray(arrayOfNames);
            System.Console.WriteLine("Длина массива после использования метода UnShift: " + arrayOfNames.Length);
            System.Console.WriteLine("-------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
