using System;

namespace ISM6225_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try       //this code checks to see if what you write on line 12 is a number.  If not a number (int) then it displays line 26              
            {
                Console.Write("Enter numbers of row for '*' pyrmaid pattern: ");   //Prompt to end user to enter a number
                int i, j, n;  // new variables as integers 
                n = Convert.ToInt32(Console.ReadLine());  // method to convert a specified value to a 32-bit signed integer.
                for (i = 0; i <= n; i++)  // loop statment, set i to 0, if i (0) is less than or equal to entered number add 1 to i, keep going until i is less than or equal to entered number
                {
                    for (j = 1; j <= n - i; j++)
                        Console.Write(" ");  // j is 1, when j less then or equal to enterd number minus 1 then write "" (space); keep adding 1 to j
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*"); // j is 1, when j less then or equal to 2 multiple i value - 1 then write * keep adding i to j
                    Console.Write("\n"); // write space
                }
            }
            catch
            {
                Console.WriteLine("You didn't enter a number, please rerun program and enter a numberic value"); // display this when line 12 isn't number
            }


            try    // try catch stattment, checks if entered  text line 14 is a number.  IF so continue else throw up catch, line 28
            {
                int i, n, sum = 0;  // 3 interger variables
                Console.Write("Enter # : "); // need user input
                n = Convert.ToInt32(Console.ReadLine());  // method to convert a specified value to a 32-bit signed integer.
                Console.Write("Starting from 1, the odd numbers based on your input :"); //writes text in quotes

                for (i = 1; i <= n; i++)    // loop statement, set i to 0, if i (0) is less than or equal to entered number add 1 to i, keep going until i is less than or equal to entered number.  in next pass add 1 to i (i++)
                {
                    Console.Write("{0} ", 2 * i - 1);  // return string, 2 multiple i -1, ist odd number, keep doing until for is no longer true; write each odd number
                    sum += 2 * i - 1; // sum int = add up all numbers
                }

                Console.Write("\nWhen you add up all the odd numbers you get: {1} \n", n, sum); // new line display sum of all odd numbers
            }

            catch
            {
                Console.WriteLine("You didn't enter a number, please rerun program and enter a numberic value"); // if line 14 is not number then display this line.
            }


            static bool MonotonicCheck(int[] A)
            {
                bool checkIncrease = true; // boolean value (true, false or null) 
                bool checkDecrease = true; // boolean value (true, false or null) 
                for (int x = 0; x < A.Length - 1; x++) // checks increase, new int of x.  IF x less then lenght of int a - 1, do if and add 1 to x
                {
                    if ((A[x] <= A[x + 1]) && (checkIncrease == true)) // if both conditions are true set checkincrease to true else false (line 22)
                    {
                        checkIncrease = true;
                    }
                    else
                    {
                        checkIncrease = false;
                    }
                }
                for (int x = 0; x < A.Length - 1; x++) // Check Decrease set in x to 0, 0 less then lengh of a-1, if so do if and add 1 to x
                {
                    if ((A[x] >= A[x + 1]) && (checkDecrease == true)) // if both conditions are true set checkdecrese to to else false (line 33)
                    {
                        checkDecrease = true;
                    }
                    else
                    {
                        checkDecrease = false;
                    }
                }
                if ((checkIncrease) || (checkDecrease))  // return one of the values
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            int[] A = { 1, 2, 2, 6 };     // sets value of a
            bool check = MonotonicCheck(A); // checks if its an inrease or decrease
            Console.WriteLine(check);  // writes back either true or false



            static int DiffK(int[] arr, int y, int z) // define new vales for array and two intergers
            {
                int count = 0; // define a new interger called count and set value to o
                               // Pick all elements one by one 
                for (int i = 0; i < y; i++)  // new integer i with value of 0, if i is less than length of array  then move to for  and add 1 to value of i
                {
                    for (int j = i + 1; j < y; j++) // check for pair, new integer of j which is value of i plus 1, check if j less then n and move for if, if yes then add 1 for j and repeate 

                        if (arr[i] - arr[j] == z || arr[j] - arr[i] == z) count++;  // checks arr value of i - arr of j and if that is equal to k (line 24) or array of j - ary of i = k +1 to count
                }
                return count;
            }
            
            {
                int[] arr = { 3, 1, 4, 1, 5 };  // set value of array
                int p = arr.Length; // value of intteger n is lengh of array *attribute'
                int k = 2; // integer k value is set to 2
                Console.WriteLine("Count diffpairs = " + DiffK(arr, p, k)); //write text along with values of arr, n, k
            }

            string keyboard = "abcdefghijklmnopqrstuvwxyz";  // define varible keyboard as string with a value
            Console.WriteLine("please enter your text :"); // user input of text
            string word = Console.ReadLine();  //read above entered line and set as new string value of word
            Console.WriteLine("Length of input = " + word.Length); // using above string use attribute length to determine number of characters


            for (int i = 0; i < word.Length; i++) // loop statment, set i to 0, if i (0) is less than or equal to lenght of entered number, keep going until i is less than or equal to entered number
            {
                Console.WriteLine(keyboard.IndexOf(word.Substring(i, 1)) + "-position on keyboard"); // enter value of i followed by text in quotes
            }
            int len = word.Length;  // new value interger value of len which value of word.length

            if (len == 1) // if len of entered text is 1 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1));  //new integer value of a, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.WriteLine(a);  //write text plus value of a
            }

            if (len == 2) // if len of entered text is 2 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1));  //new integer value of a, index position value of 1st character suing keyboard string
                int b = keyboard.IndexOf(word.Substring(1, 1));  //new integer value of b, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.Write(a + (b - a));
            }

            if (len == 3) // if len of entered text is 3 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1));  //new integer value of a, index position value of 1st character suing keyboard string
                int b = keyboard.IndexOf(word.Substring(1, 1));  //new integer value of b, index position value of 1st character suing keyboard string
                int c = keyboard.IndexOf(word.Substring(2, 1));  //new integer value of c, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.Write(a + (b - a) + (c - b));
            }

            if (len == 4) // if len of entered text is 4 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1)); //new integer value of a, index position value of 1st character suing keyboard string
                int b = keyboard.IndexOf(word.Substring(1, 1));  //new integer value of b, index position value of 1st character suing keyboard string
                int c = keyboard.IndexOf(word.Substring(2, 1)); //new integer value of c, index position value of 1st character suing keyboard string
                int d = keyboard.IndexOf(word.Substring(3, 1)); //new integer value of d, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.Write(a + (b - a) + (c - b) + (d - c));
            }

            if (len == 5) // if len of entered text is 5 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1)); //new integer value of a, index position value of 1st character suing keyboard string
                int b = keyboard.IndexOf(word.Substring(1, 1)); //new integer value of b, index position value of 1st character suing keyboard string
                int c = keyboard.IndexOf(word.Substring(2, 1)); //new integer value of c, index position value of 1st character suing keyboard string
                int d = keyboard.IndexOf(word.Substring(3, 1)); //new integer value of d, index position value of 1st character suing keyboard string
                int e = keyboard.IndexOf(word.Substring(4, 1)); //new integer value of e, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.Write(a + (b - a) + (c - b) + (d - c) + (e - d));
            }

            if (len == 6) // if len of entered text is 6 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1)); //new integer value of a, index position value of 1st character suing keyboard string
                int b = keyboard.IndexOf(word.Substring(1, 1)); //new integer value of b, index position value of 1st character suing keyboard string
                int c = keyboard.IndexOf(word.Substring(2, 1)); //new integer value of c, index position value of 1st character suing keyboard string
                int d = keyboard.IndexOf(word.Substring(3, 1)); //new integer value of d, index position value of 1st character suing keyboard string
                int e = keyboard.IndexOf(word.Substring(4, 1)); //new integer value of e, index position value of 1st character suing keyboard string
                int f = keyboard.IndexOf(word.Substring(5, 1)); //new integer value of f, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.Write(a + (b - a) + (c - b) + (d - c) + (e - d) + (f - e));
            }

            if (len == 7) // if len of entered text is 7 do below
            {
                int a = keyboard.IndexOf(word.Substring(0, 1)); //new integer value of a, index position value of 1st character suing keyboard string
                int b = keyboard.IndexOf(word.Substring(1, 1)); //new integer value of b, index position value of 1st character suing keyboard string
                int c = keyboard.IndexOf(word.Substring(2, 1)); //new integer value of c, index position value of 1st character suing keyboard string
                int d = keyboard.IndexOf(word.Substring(3, 1)); //new integer value of d, index position value of 1st character suing keyboard string
                int e = keyboard.IndexOf(word.Substring(4, 1)); //new integer value of e, index position value of 1st character suing keyboard string
                int f = keyboard.IndexOf(word.Substring(5, 1)); //new integer value of f, index position value of 1st character suing keyboard string
                int g = keyboard.IndexOf(word.Substring(5, 1)); //new integer value of g, index position value of 1st character suing keyboard string
                Console.Write("total time = "); Console.Write(a + (b - a) + (c - b) + (d - c) + (e - d) + (f - e) + (g - f));
            }
            if (len > 7) // if len of entered text is >7 do below
            {
                Console.WriteLine("Your text needs to be shorter than 8 characters, to calcualte space between characters"); //write following text
            }

            static int min(int x, int y, int z) // three new interger variables with minimum values
            {
                if (x <= y && x <= z) // two conditions - if x less than equal to y AND x less then or equal to z
                    return x; // if above line is true then return 
                if (y <= x && y <= z) // two conditions - if y less than or equal to x AND y less than or equal to z 
                    return y; //if aobve line is true then return
                else
                    return z; // if line 9 and 11 are false return z
            }

            static int editDistDP(String str1, String str2, int m, int n) // two new string values and two new interger values
            {
                int[,] dp = new int[m + 1, n + 1]; //new array table to store results

                // Fill d[][] in bottom up manner 
                for (int i = 0; i <= m; i++) // loop statment, set i to 0, if i (0) is less than or equal to entered number m add 1 to i, keep going until i is less than or equal to entered number
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (i == 0) // If first string is empty, only option is to insert all characters of second string 
                            dp[i, j] = j; // min operations of j


                        else if (j == 0)  // If second string is empty, only option is to remove all characters of second string 
                            dp[i, j] = i; // min = i 

                        else if (str1[i - 1] == str2[j - 1]) // If last characters are same, ignore last char and recur for remaining string 
                            dp[i, j] = dp[i - 1, j - 1];

                        else  // If the last character is different, consider all possibilities and find the  
                            dp[i, j] = 1 + min(dp[i, j - 1], // Insert 
                                               dp[i - 1, j], // Remove 
                                               dp[i - 1, j - 1]); // Replace 
                    }
                }

                return dp[m, n]; // return values
            }
            
            {
                String str1 = "goulls"; // value of string 1
                String str2 = "gobulls"; // value of string 2
                Console.Write(editDistDP(str1, str2, str1.Length, str2.Length));  // write to console
            }

        }
    }
}
