using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseInteger r = new ReverseInteger();
            //Console.WriteLine(r.Reverse(120));

            //PalindromeNumber p = new PalindromeNumber();
            //Console.WriteLine(p.IsPalindrome(121));

            //ValidParentheses v = new ValidParentheses();
            //Console.WriteLine(v.IsValid("(){}"));

            //RemoveElement r = new RemoveElement();
            //int[] nums = new int[] {0,1,2,2,3,0,4,2};
            //int val = 2;
            //r.Remove(nums, val);

            //SearchInsertPosition s = new SearchInsertPosition();
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //int val = 7;
            //Console.WriteLine(s.SearchInsert(nums, val));

            //Haystack h = new Haystack();
            //Console.WriteLine(h.StrStr("aaaa", "aaa"));

            //MaximumSubarray m = new MaximumSubarray();
            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int n = arr.Length;
            //int max_sum = m.MaxSubArray(arr, 0, n - 1);
            //Console.WriteLine(max_sum);

            //LengthofLastWord l = new LengthofLastWord();
            //Console.WriteLine(l.LengthOfLastWord("a"));

            //PlusOne p = new PlusOne();
            //int[] i = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //int[] i = new int[] { 9, 9 };
            //int[] i = new int[] { 9 };
            //int[] i = new int[] { 1, 2, 3 };
            //int[] i = new int[] { 4, 3, 2, 1 };
            //p.PlusOneS(i);

            //AddBinary a = new AddBinary();
            //a.AddBinaryS("110", "11");
            //Console.WriteLine(a.AddBinaryS("11", "110"));
            //Console.WriteLine(a.AddBinaryS("11", "1"));
            //Console.WriteLine(a.AddBinaryS("1010", "1011"));
            //Console.WriteLine(a.AddBinaryS("1111", "1111"));
            //Console.WriteLine(a.AddBinaryS("110010", "10111"));

            //ComputeSquare c = new ComputeSquare();
            //Console.WriteLine(c.MySqrt(8));

            //ClimbingStairs s = new ClimbingStairs();
            //Console.WriteLine(s.ClimbStairs(44));

            //MergeSortedArray me = new MergeSortedArray();
            //int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int m = 3, n = 3;
            //int[] nums2 = new int[] { 2, 5, 6 };
            //me.Merge(nums1, m, nums2, n);

            //HouseRobber h = new HouseRobber();
            //int [] nums = new int[] { 1, 3, 1, 3, 100 };
            //Console.WriteLine(h.Rob(nums));

            //PascalTriangle p = new PascalTriangle();
            //p.Generate(5);

            //PascalTriangleII p = new PascalTriangleII();
            //p.GetRow(0);

            //BestTimeToBuyAndSellStock b = new BestTimeToBuyAndSellStock();
            //int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            //Console.WriteLine(b.MaxProfit(prices));

            //SingleOne s = new SingleOne();
            //int[] nums = new int[] { 4, 1, 2, 1, 2 };
            //Console.WriteLine(s.SingleNumber(nums));

            //FactorialTrailingZeroes f = new FactorialTrailingZeroes();
            //Console.WriteLine(f.TrailingZeroes(30));

            //CountPrime c = new CountPrime();
            //Console.WriteLine(c.CountPrimes(499979));

            //SetMatrixZeroes s = new SetMatrixZeroes(); 
            //int[] arr1 = new[] { 1, 1, 1 };
            //int[] arr2 = new[] { 1, 0, 1 };
            //int[] arr3 = new[] { 1, 1, 1 };

            //int[] arr1 = new[] { 0, 1, 2, 0 };
            //int[] arr2 = new[] { 3, 4, 5, 2 };
            //int[] arr3 = new[] { 1, 3, 1, 5 };
            //int[][] matrix = new [] { arr1, arr2, arr3 };
            //s.SetZeroes(matrix);

            //SortColors s = new SortColors();
            //int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            //s.SortColor(nums);

            //SquareNumber s = new SquareNumber();
            //Console.WriteLine(s.isSquareNumber(16));

            //IsomorphicStrings i = new IsomorphicStrings();
            //string s = "abba";
            //string t = "abba";
            //Console.WriteLine(i.IsIsomorphic(s, t));


            //ContainsDuplicate c = new ContainsDuplicate();
            //int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            //Console.WriteLine(c.ContainsDuplicates(nums));

            //PowerOfTwo p = new PowerOfTwo();
            //Console.WriteLine(p.IsPowerOfTwo(10));

            //ValidAnagram v = new ValidAnagram();
            //Console.WriteLine(v.IsAnagram("rat", "car"));
            //Console.WriteLine(v.IsAnagram("anagram", "nagaram"));

            UglyNumber u = new UglyNumber();
            Console.WriteLine(u.IsUgly(2));
        }
    }
}
