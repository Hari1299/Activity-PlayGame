using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        public static void FirstProgram()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < 10; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                numbers.Add(k);
            }
            Console.WriteLine("The number divisible by 7");
            foreach (var i in numbers)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void SecondProgram()
        {
            Console.WriteLine("Enter the minimum value");
            int starting_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum value");
            int ending_no = Convert.ToInt32(Console.ReadLine());
            if (starting_no > ending_no)
            {
                Console.WriteLine("Invalid entry");
            }
            else
            {
                Console.WriteLine("The prime numbers between {0} and {1} are :", starting_no, ending_no);
                for (int i = starting_no; i <= ending_no; i++)
                {
                    int flag = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine(i);
                }
            }
        }

        public static void ThirdProgram()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                    break;
                else
                    numbers.Add(i);
            }
            IEnumerable<int> duplicates = numbers.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            Console.WriteLine("repeated elements are:");
            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }
        }
        public static void FourthProg()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    break;
                else
                    numbers.Add(i);
            }
            var num = (from i in numbers
                       select i).OrderBy(i => i).ToList();
            Console.WriteLine("Numbers after sorting");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }

        public static void FifthProgram()
        {
            int count = 0;
            do
            {
                Console.WriteLine("Username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user == "Admin" & password == "admin")
                {
                    Console.WriteLine("Welcome!!!");
                    break;
                }

                else
                {
                    Console.WriteLine("Inavalid uname or password");
                    Console.WriteLine("Try again");
                    count = count + 1;
                }
            } while (count < 3);
            if (count >= 3)
            {
                Console.WriteLine("Sorry you have done 3 times");
            }
        }

        static void SixthProgram()
        {
            string[] arr = { "kite", "four", "neat", "play", "goal" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the guess word");
                string GuessWord = Console.ReadLine();
                string guess = arr[i];
                int cow = 0, bulls = 0;
                if (guess.Length == GuessWord.Length)
                {

                    for (i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == GuessWord[i])
                        {
                            cow += 1;
                        }
                        else
                        {
                            for (int j = 0; j < guess.Length; j++)
                            {
                                if (guess[i] == GuessWord[j] && i != j)
                                {
                                    bulls += 1;
                                }
                            }
                        }
                        Console.WriteLine("Cows" + cow + " Bulls" + bulls);
                    }

                    if (cow == guess.Length)
                    {
                        Console.WriteLine("You Won the Game");
                    }
                    Console.WriteLine("   ");
                }
                else
                {
                    Console.WriteLine("enter " + guess.Length + " letter a Word");
                    
                }
            }

        }

        public static void SeventhProgram()
        {
            {
                Console.WriteLine("Please enter the Card Number");
                string Cardnumber = Console.ReadLine();
                if (Cardnumber.Length == 16)
                {
                    Cardnumber = reverse(Cardnumber);
                    Console.WriteLine(Cardnumber);
                    string sum = Sumandmul(Cardnumber);
                    Console.WriteLine(sum);
                    string mod = ModAndCheck(sum);
                    Console.WriteLine(mod);
                }
                else
                    Console.WriteLine("Enter card length is 16");
            }

             static string reverse(string number)
            {
                string output = string.Empty;
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    output += number[i];
                }
                return output;
            }
            static string Sumandmul(string number)
            {
                int num_convert, mul_, sum = 0, evensum = 0, oddsum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    char v = number[i];
                    num_convert = (int)Char.GetNumericValue(v);
                    if ((i + 1) % 2 == 0)
                    {
                        mul_ = num_convert * 2;
                        if (mul_ >= 10)
                        {
                            while (mul_ > 0)
                            {
                                int n = mul_ % 10;
                                evensum += n;
                                mul_ = mul_ / 10;
                            }
                        }
                        else
                            evensum += mul_;
                    }
                    else
                    {
                        oddsum += num_convert;
                    }
                    sum = evensum + oddsum;
                }
                return Convert.ToString(sum);
            }
        }

        private static string ModAndCheck(string sum)
        {
            int number = Convert.ToInt32(sum);
            if (number % 10 == 0)
                return "Valid Card";
            else
                return "Please verify correct number";
        }
        static void Main(string[] args)
        {
            FirstProgram();
            SecondProgram();
            ThirdProgram();
            FourthProg();
            FifthProgram();
            SixthProgram();
            SeventhProgram();
            // Console.WriteLine("Hello World!");
        }
    }
}
