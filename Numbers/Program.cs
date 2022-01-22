using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] OrderArrayForStartToEnd(int[] arr)
            {
                Array.Sort(arr);
                Array.Reverse(arr);
                var orderderArray = new int[arr.Length-1];
                var s = 0;
                var e = arr.Length - 2; //bu şekilde yaptığımızda en küçük elemanı çıkartabiliriz dizeden. çıkartmak istemediğimizde burası -1 diğerleri -1'siz oluyor.

                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (i % 2 == 0)
                    {
                        orderderArray[s] = arr[i];
                        s++;
                    }
                  
                    
                    else
                    {
                        orderderArray[e] = arr[i];
                        e--;
                    }
                }

                return orderderArray;
            }
            int[] sample1 = { 4, 13, 8, 9, 7, 1, 6 };
            int[] sample2 = { 16, 23, 7, 11, 3, 14 };
            var result1 = OrderArrayForStartToEnd(sample1);
            var result2 = OrderArrayForStartToEnd(sample2);
            var resultText = string.Join(",", result1);
            var resultText2 = string.Join(",", result2);

            Console.WriteLine(resultText);
          
            Console.WriteLine(resultText2);
           
            Console.ReadLine();
        }
    }
}
