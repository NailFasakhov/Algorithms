using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatsonArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[4] { 1, 4, 3, 2 };
            int[] arr2 = new int[5] { 1, 4, 2, 3, 2 };
            int[] arr3 = new int[6] { 1, 1, 2, 2, 3, 1 };
            int[] arr4 = new int[3] { 1, 2, 1};
            int[] arr5 = new int[2] { 1, 1 };
            int[] arr6 = new int[6] { 1, 1, 2, 2, 3, 6 };
            int[] arr7 = new int[6] { 8, 1, 2, 2, 3, 1 };

            Console.WriteLine(Sherlock(arr1));
            Console.WriteLine(Sherlock(arr2));
            Console.WriteLine(Sherlock(arr3));
            Console.WriteLine(Sherlock(arr4));
            Console.WriteLine(Sherlock(arr5));
            Console.WriteLine(Sherlock(arr6));

            Console.ReadLine();
        }
        public static bool Sherlock(int[] arr)
        {
            int n = arr.Length;
            int left = 0;
            int right = n - 1;

            int mid = left + (right - left) / 2;

            int sumLeft = 0;
            int sumRight = 0;

            bool exist = false;

            while (right != left + 1)
            {
                if (mid == 0 || mid == n - 1)
                {
                    break;
                }

                for (int i = left; i < mid; i++)
                {
                    sumLeft += arr[i];
                }

                for (int j = right; j > mid; j--)
                {
                    sumRight += arr[j];
                }

                if (sumLeft == sumRight)
                {
                    exist = true;
                    break;
                }
                else if (sumRight > sumLeft)
                {
                    sumRight = 0;

                    left = mid;

                    mid = left + (right - left) / 2;
                }
                else
                {
                    sumLeft = 0;

                    right = mid;

                    mid = left + (right - left) / 2;
                }

            }

            return exist;
        }
    }
}
