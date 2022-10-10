using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("We are going to exchange the first and last characters in a given string and return to you the new string.\nPlease enter your word : ");
            string word = Console.ReadLine();
            Console.WriteLine("\nThe result is : " + Exchange_First_Last_Letter(word));

            Console.WriteLine("How many numbers do you want to enter ? ");
            int size = Convert.ToInt32(Console.ReadLine());
            while (size <= 0)
            {
                Console.WriteLine("You must have at least 1 number : ");
                size = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Now enter the numbers : ");
            int[] enter = new int[size];
            for(int i = 0; i<size; i++)
            {
                enter[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("How many numbers are you looking for ? ");
            int size2= Convert.ToInt32(Console.ReadLine());
            while (size2 > size||size2<=0)
            {
                Console.WriteLine("You must searched between 1 and"+size+"numbers : ");
                size2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the numbers you are looking for : ");
            int[] look = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                look[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("These numbers are in the original array : " + Contains_Number(look, enter));

            Console.WriteLine("Enter a character : ");
            string test = Console.ReadLine();
            int code = Convert.ToInt32(Convert.ToChar(test));
            Console.WriteLine("His ASCII code is : "+code);
            Console.WriteLine("Enter a string and I will sort it in descending order : ");
            string str = Console.ReadLine();
            Console.WriteLine(Sorted_Value(str));
            
            Console.WriteLine("We will now compressing your string, please enter one : ");
            string notCompressed = Console.ReadLine();
            Console.WriteLine(CompressString(notCompressed));

            AmstrongNumbers(); 

            CountNumbersInArray(); 

            IsAFactorial();*/

            NumbersOfWhiteSpaces();
            Console.ReadKey();
        }
        static string Exchange_First_Last_Letter(string word)
        {
            string result = "";
            int size = word.Length;
            for(int i=0; i<size; i++)
            {
                if (i == 0) result += word[size - 1];
                else if (i == size - 1) result += word[0];
                else result += word[i];
            }
            return result;
        }
        static bool Contains_Number(int[] searched, int[] array)
        {
            bool result = false;
            bool appear = true;
            bool stop = false;
            int index = 0;
            for(int i = 0; (i<array.Length)&&(stop == false); i++)
            {
                if (array[i] == searched[0]) 
                { 
                    stop = true;
                    index = i;
                }
            }
            if (stop == true)
            {
                for (int j = index; j < searched.Length + index && appear == true; j++)
                {
                    if (array[j] != searched[j - index]) appear = false;
                }
                if (appear == true) result = true;
            }
            return result;
        }
        static string Sorted_Value(string array)
        {
            char[] array_code = new char[array.Length];
            string result = "";
            char stock;
            for(int i = 0; i<array.Length; i++)
            {
                array_code[i] = array[i];
            }
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j<array.Length-i-1; j++)
                {
                    if ((int)array_code[j] < (int)array_code[j + 1])
                    {
                        stock = array_code[j];
                        array_code[j] = array_code[j + 1];
                        array_code[j + 1] = stock;
                    }
                }
            }
            for(int i = 0; i<array.Length; i++)
            {
                result += array_code[i];
            }
            return result;
        }
        static string CompressString(string str)
        {
            string result = "";
            int compt = 1;
            for(int i = 0; i<str.Length-1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    compt++;
                }
                else
                {
                    result += str[i] + Convert.ToString(compt);
                    compt = 1;
                }
                
            }
            result += str[str.Length-1]+Convert.ToString(compt);
            return result;
        }
        static void AmstrongNumbers()
        {
            int[] arr = new int[3];
            Console.Write("The amstrong numbers between 0 and 999 are : 0, 1");
            for(int i = 152; i<1000; i++)
            {
                arr[0] = i / 100;
                arr[1] = (i - (arr[0] * 100)) / 10;
                arr[2] = i - (arr[0] * 100 + arr[1] * 10);

                if ((Math.Pow(arr[0], 3) + Math.Pow(arr[1], 3) + Math.Pow(arr[2], 3)) == i) Console.Write(", " + i);
            }
        }
        static void CountNumbersInArray()
        {
            Console.Write("Choose the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] enter = new int[size];
            int[] work = new int[size];
            int compt = 0;
            for(int i = 0; i<size; i++)
            {
                Console.Write("\n[" + i + "] : ");
                enter[i] = Convert.ToInt32(Console.ReadLine());
                work[i] = enter[i];
            } 
            for(int i = 0; i<size; i++)
            {
                for(int j = i; j<size; j++)
                {
                    if (work[j] == enter[i])
                    {
                        compt++;
                        work[j] = 0;
                    }
                }
                if(compt!=0) Console.WriteLine(enter[i] + " is " + compt + " times");
                compt = 0;
            }
        }
        static void IsAFactorial()
        {
            Console.Write("Enter the number you want to check : ");
            int enter = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for(int i = 0; (Factorial(i)<=enter)&&(check == false); i++)
            {
                if (Factorial(i) == enter)
                {
                    check = true;
                    Console.WriteLine("\n" + enter + " is the factorial of " + i);
                }
            }
            if(check==false) Console.WriteLine(enter + " is not a factorial.");
        }
        static int Factorial(int x)
        {
            int result = 1;
            if (x > 0)
            {
                for(int i = x; i>0; i--)
                {
                    result = result * i;
                }
            }
            return result;
        }
        static void NumbersOfWhiteSpaces()
        {
            Console.WriteLine("Enter your sentence : ");
            string sentence = Console.ReadLine();
            int compt = 0;
            for(int i = 0; i<sentence.Length; i++)
            {
                if (sentence[i] == ' ') compt++;
            }
            Console.WriteLine("There are/is " + compt + " space(s) in the sentence : " + sentence);
        }
    }
}
