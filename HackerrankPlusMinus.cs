using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        int positiveNumbers = 0;
        int negativeNumbers = 0;
        int zeroNumbers = 0;
        
        ReadLine();
        int arr_temp = ReadLine().Split(' ');
        int dizi = Array.ConvertAll(arr_temp, Int32.Parse);

        for (int arr_i = 0; arr_i < arr.Length; arr_i++)
        {
            if (dizi[arr_i] > 0)
                ++positiveNumbers;
            else if (dizi[arr_i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
        }

        WriteLine((double)positiveNumbers / dizi.Length);
        WriteLine((double)negativeNumbers / dizi.Length);
        WriteLine((double)zeroNumbers / dizi.Length);
    }
}
