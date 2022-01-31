//Anusha Kamath

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            int len = s.Length;
            if (len <= 10000)
            {
                string final_string = RemoveVowels(s);
                Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lenght of input string should be less than 10000");
            }


          

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

          

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: {0}", rotated_string);
            Console.WriteLine();

           
            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();
        }
        private static string RemoveVowels(string s)
        {//use the regular expressions package with the replace method to replace the vowels with null space in the string s
                try
                {
                    // write your code here
                    if (s.Length >= 0 && s.Length <= 1000)
                    {
                        String final_string = Regex.Replace(s, "[aeiou]", "", RegexOptions.IgnoreCase);
                        return final_string;
                    }
                    else
                    {
                        return "Invalid String";
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {

            try
            {
                //use the string join method to join all the words in the array bulls_string1
                string word1 = string.Join(" ", bulls_string1);
                //replace the spaces with null
                string first = word1.Replace(" ", "");
                string word2 = string.Join(" ", bulls_string2);
                string second = word2.Replace(" ", "");
                //compare the two strings
                if (!first.Equals(second))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //compute the length of the array
                int len = bull_bucks.Length;
                
                int[] input = new int[len];
                int count = 0;
                for (int i = 0; i < len; i++)
                {
                    //assign array element to num
                    int num = bull_bucks[i];
                    //check if input array contains num
                    if (input.Contains(num))
                    {
                        //decrease count 
                        count = count - num;
                    }
                    else
                    {
                        //increment count
                        count = count + num;
                        input[i] = bull_bucks[i];
                    }
                }
                return count;
            }
            catch
            {
                throw;
            }
        }
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                int len = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));
                int sum = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (i == j)
                        {
                            sum+= bulls_grid[i, j];
                        }
                        else if (i + j == (len - 1))
                        {
                            sum+= bulls_grid[i, j];
                        }
                    }
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                //length of the array
                int len = indices.Length;
                string res = "";
                for (int i = 1; i <=len; i++)
                {
                    //get the index of the num
                    int num = Array.IndexOf(indices, i);
                    res+=  bulls_string[num];
                }
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                //length of the string
                int len = bulls_string6.Length;
                //index of the character
                int num = bulls_string6.IndexOf(ch, 0, len);
                
                for (int i = num; i >= 0; i--)
                {
                    prefix_string += bulls_string6[i];
                }
                for (int i = num + 1; i < len; i++)
                {
                    prefix_string += bulls_string6[i];
                }
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}