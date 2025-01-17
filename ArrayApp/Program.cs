﻿using System;

namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Array.CreateInstance(typeof(int), 4);

            arr.SetValue(23, 0);
            arr.SetValue(44, 1);
            arr.SetValue(61, 2);
            arr.SetValue(55, 3);
            

            // 0 : 23 1:44 2:61 3:55

            Console.WriteLine(arr.GetValue(0));
            try
            {
                Console.WriteLine(arr.GetValue(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
