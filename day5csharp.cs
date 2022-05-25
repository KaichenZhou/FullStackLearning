/*
 * Day5 hw Assignment A
 * Test your Knowledge
 * 1. What type would you choose for the following “numbers”?
 * A person’s telephone number = int
 * A person’s height = double
 * A person’s age = int
 * A person’s gender (Male, Female, Prefer Not To Answer) = string
 * A person’s salary = double
 * A book’s ISBN = string
 * A book’s price = double
 * A book’s shipping weight  = double
 * A country’s population = int
 * The number of stars in the universe = long
 * The number of employees in each of the small or medium businesses in the United Kingdom 
 * (up to about 50,000 employees per business) = int
 * 
 * 2. What are the difference between value type and reference type variables? What is boxing and unboxing?
 * 1) value type will directly hold the value, while reference type will hold the memory address or reference for this value
 * 2) value type are stored in stack memory, while reference types will be stored in heap memory
 * 3) value type will not be collected by garbage collector, while reference type will be collected by garbage collector
 * 4) value type can be created by Struct or Enum, but reference type can be created by class, interface, delegate, or array
 * 5) value type cannot accept null values, but reference types can accept null values
 * 
 * 3. What is meant by the terms managed resource and unmanaged resource in .NET
 * manage source is managed by garbage collector
 * unmanaged source: file, steams,database connectin call dispose() from IDisposable interface to release  
 * 
 * 4. Whats the purpose of Garbage Collector in .NET?
 * Garbage Collector: automatic memory manager•Benefits:
 * Don’t need to manually release memory
 * Allocates objects on managed heap efficiently
 * 
 * Playing with Console App
 * Using just the ReadLine and WriteLine methods and your current knowledge of variables,
 * you can have the user pass in quite a few bits of information. Using this approach, create a
 * console application that asks the user a few questions and then generates some custom
 * output for them. For instance, your program could generate their "hacker name" by asking
 * them their favorite color, their astrology sign, and their street address number. The result
 * might be something like "Your hacker name is RedGemini480.
 * 
 *

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your harker name is: ");
            string hn = Console.ReadLine();
            Console.WriteLine("Your favorite color is: ");
            string fc = Console.ReadLine();
            Console.WriteLine("Your address number is: ");
            int an = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your harker name is: " + hn);
            Console.WriteLine("Your favorite color is: " + fc);
            Console.WriteLine("Your address number is: " + an);
        }
  
    }
}


Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.
Composite Formatting to learn how to align text in a console application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type \t|\tnumber of bytes ");
            Console.WriteLine($"sbyte\t|\t {sizeof(sbyte)}");
            Console.WriteLine($"byte \t|\t {sizeof(byte)} ");
            Console.WriteLine($"short\t|\t {sizeof(short)}");
            Console.WriteLine($"ushort\t|\t {sizeof(ushort)}");
            Console.WriteLine($"int \t|\t {sizeof(int)}");
            Console.WriteLine($"uint \t|\t {sizeof(uint)} ");
            Console.WriteLine($"long \t|\t {sizeof(long)}");
            Console.WriteLine($"ulong\t|\t {sizeof(ulong)} ");
            Console.WriteLine($"float\t|\t {sizeof(float)} ");
            Console.WriteLine($"double\t|\t {sizeof(double)}");
            Console.WriteLine($"decimal\t|\t {sizeof(decimal)} ");
        }

    }
}

2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of centuries: ");
            long centuries = Convert.ToInt64(Console.ReadLine());
            long years = centuries * 100;
            long days = years * 365;
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            long nanoseconds = microseconds * 1000;
            Console.Write(centuries + " centuries\n = ");
            Console.Write(years + " years\n = ");
            Console.Write(days + " days\n = ");
            Console.Write(hours + " hours\n = ");
            Console.Write(minutes + " minutes\n = ");
            Console.Write(seconds + " seconds\n = ");
            Console.Write(milliseconds + " milliseconds\n = ");
            Console.Write(microseconds + " microseconds\n = ");
            Console.Write(nanoseconds + " nanoseconds ");
        }
  
    }
}

Test your Knowledge
1. What happens when you divide an int variable by 0? 
Exception Unhandled
2. What happens when you divide a double variable by 0?    
infinity such as  0.00000000000000000......
3. What happens when you overflow an int variable, that is, set it to a value beyond itsrange? 
Exception Unhandled

4. What is the difference between x = y++; and x = ++y;? 
y++ means executes the statement and then increments the value by 1
++y means increments the value by 1 and then executes the statement.

5. What is the difference between break, continue, and return when used inside a loop statement?
break means the statement jumps out of a loop.
continue means the statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
return means end the whole loop.

6. What are the three parts of a for statement and which of them are required?
i=0, i<10, i++
i=0 is required. The code can run the first time when the condition i = 0.

7. What is the difference between the = and == operators?
x = 10 means the assign the value 10 to x
x == 10 means to check whether the two given operands are equal or not

8. Does the following statement compile? for ( ; true; ) ;
9. What does the underscore _ represent in a switch expression?
char grade = "A";
switch (grade) 
{
    case A:
    Console.WriteLine("Your grade is A");
    break;
    case B:
    Console.WriteLine("Your grade is B");
    break;
    case C:
    Console.WriteLine("Your grade is C");
    break;
    default:
    Console.WriteLine("Invalid grade.");
    break;
}
10. What interface must an object implement to be enumerated over by using the foreach statement?
The IEnumerable interface provides support for the foreach iteration. 
IEnumerable requires that you implement the GetEnumerator method.

2.Print - a - Pyramid.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            int i, j;
            int n = 4; //the number of pyramid row  
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
3. Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
int guessedNumber = int.Parse(Console.ReadLine());
Note that the above code will crash the program if the user doesn't type an integer value.
For this exercise, assume the user will only enter valid guesses

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number you guess between 1 to 3: ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            int randomNumber = new Random().Next(1, 3);
            bool correct = false;
            while (!correct)
            {   
                restart:
                Console.Write("Guess a number between 1 and 3: ");
                if (guessedNumber > randomNumber)
                {
                    Console.Write("Too high, try again");
                    break;

                }
                if (guessedNumber < randomNumber)
                {
                    Console.Write("Too low, try again");
                    break;
                }
                else
                {
                    correct = true;
                    Console.Write("Yes, you guessed the number.");
                }

            }
        }
    }
}
4.Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .

5.Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings. If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            int currentHour = currentDateTime.Hour;
            int morningTime = 6;
            int AfternoonTime = 12;
            int EveningTime = 16;
            int nightTime = 21;
            if (morningTime <= currentHour && currentHour < AfternoonTime)
            {
                Console.WriteLine("Good morning!");
            }
            if (AfternoonTime <= currentHour && currentHour < EveningTime)
            {
                Console.WriteLine("Good Afternoon!");
            }
            if (EveningTime <= currentHour && currentHour < nightTime)
            {
                Console.WriteLine("Good Evening!");
            }
            if (nightTime <= currentHour || currentHour < morningTime)
            {
                Console.WriteLine("Good Night!");
            }
            Console.WriteLine("Right now it is {0}:{1} o'clock.", currentDateTime.Hour, currentDateTime.Minute);
        }
    }
}
6.Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable.
Your output should look something like this:
0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
0,2,4,6,8,10,12,14,16,18,20,22,24
0,3,6,9,12,15,18,21,24
0,4,8,12,16,20,24

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Csharp
{
    public class day5csharp
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 24; i ++)
            {                
                for (int y = 0; y <= 24; y += i)
                {
                    Console.Write(y.ToString().PadLeft(4));
                }            
                Console.WriteLine();
            }
        }
    }    
}

 * Day5 hw Assignment B
 * Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
Using StringBuilder When I need a mutable string.

2. What is the base class for all arrays in C#?
The array class

3. How do you sort an array in C#?
Array.Sort();

4. What property of an array object can be used to get the total number of elements in an array?
Length

5. Can you store multiple data types in System.Array?
No

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. 
The CopyTo() method copies the elements into another existing array. 

Practice Arrays
1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly

using System;
namespace day5csharp
{
    class day5csharp
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Total length of array is " + num.Length);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("The elements in original array are " + num[i]);
            }
            var num2 = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                num2[i] = num[i];
                Console.WriteLine("The elements in new array are " + num2[i]);
            }
        }
    }
}

2.Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows:
+ some item
- some item
--
Your program should read in the user's input and determine if it begins with a “+” or “-“ or
if it is simply “—“ . In the first two cases, your program should add or remove the string
given ("some item" in the example). If the user enters just “—“ then the program should
clear the current list. Your program can start each iteration through its loop with the
following instruction:
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
*/
using System;
namespace day5csharp
{
    class day5csharp
    {
        static void add()
        {
            string[] store = new string[10];
            List<string> arr = store.ToList();

            //string[] arr = new string[] { "Hi" };
            //List<string> ls = arr.ToList();
            arr.Add("Apple");
            arr.Add("Orange");
            arr.Add("Milk");

            store = arr.ToArray();
            foreach (var e in store)
            {
                Console.WriteLine(e);
            }
        }
       
        static void Main(string[] args)
        {
            add();
        }
    }
}



/*

3. Write a method that calculates all prime numbers in given range and returns them as array
of integers

using System;
namespace day5csharp
{
    class day5csharp
    {
        static int[] FindPrimesInRange(int startNum, int endNum)  //startNum, endNum
        {
            int[] p = new int[endNum - startNum + 1];
            int i, j;
            int arrayIndex = 0;
            for (i = startNum; i <= endNum; i++)
            {
                if (i == 1 || i == 0)
                {
                    continue;
                }
                int flag = 1;
                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    p[arrayIndex++] = i;
                }
            }
            int[] arr = new int[arrayIndex];
            for (i = 0; i < arrayIndex; i++)
            {
                arr[i] = p[i];
            }

            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting range and ending range of prime numbers");
            int startNum = Convert.ToInt32(Console.ReadLine());
            int endNum = Convert.ToInt32(Console.ReadLine());
            int[] primes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(" ", primes));
        }
    }
}


4. Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
Input Output Comments
3 2 4 -1 3 2 5 6 rotated1[] = -1 3 2 4
2 rotated2[] = 4 -1 3 2
sum[] = 3 2 5 6
1 2 3 4 5 12 10 8 6 9 rotated1[] = 5 1 2 3 4
3 rotated2[] = 4 5 1 2 3
rotated3[] = 3 4 5 1 2
sum[] = 12 10 8 6 9



5. Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one.
Input Output
2 1 1 2 3 3 2 2 2 1 2 2 2
1 1 1 2 3 1 3 3 1 1 1
4 4 4 4 4 4 4 4
0 1 1 5 2 2 6 3 3 1 1


using System;
namespace day5csharp
{
    class day5csharp
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 1, 2, 3, 4, 3 };  
            int startNum = 0, endNum = 0, maxCount = 0, count = 0, temp = 0;
            int arryLen = arr.Length - 1;

            for (int i = 0; i < arryLen; i++)
            {
                if (arr[i] == arr[i + 1] - 1)
                {
                    count++;
                    maxCount = count;
                    endNum = i + 1;
                }
                else
                {
                    temp = startNum;
                    startNum = i + 1;
                    count = 0;
                }
            }
            for (int i = 0; i <= maxCount; i++)
            {
                Console.WriteLine(arr[temp + i]);
            }
        }
    
    }
}



7. Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them
Input Output
4 1 1 4 2 3 4 4 1 2 4 9 3 The number 4 is the most frequent (occurs 5 times)
7 7 7 0 2 2 2 0 10 10 10 The numbers 2, 7 and 10 have the same maximal
frequence (each occurs 3 times). The leftmost of them is 7.

using System;
namespace day5csharp
{
    class day5csharp
    {
        static void printNumber(int[] arr, int n, int k)
        {
            Dictionary<int, int> mp = new Dictionary<int, int>();
  
            for (int i = 0; i < n; i++)
            {           
                if (mp.ContainsKey(arr[i]))
                {
                    mp[arr[i]] = mp[arr[i]] + 1;
                }
                else
                {
                    mp.Add(arr[i], 1);
                }
            }

            List<List<int>> freq = new List<List<int>>();

            for (int i = 0; i <= n; i++)
                freq.Add(new List<int>());
            foreach (KeyValuePair<int, int> x in mp)
                freq[x.Value].Add(x.Key);
            int count = 0;
            for (int i = n; i >= 0; i--)
            {
                foreach (int x in freq[i])
                {
                    Console.WriteLine("The number " + x + " is the most frequent");
                    Console.WriteLine("It occurs " + i + " times");
                    count++;
                    if (count == k)
                        return;
                }
            }
        }
        public static void Main(String[] args)
        {
            int[] arr = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
            int n = arr.Length;
            int k = 1;
            printNumber(arr, n, k);
        }      
    }
}






Practice Strings
1. Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop
Input Output
sample elpmas
24tvcoi92 29iocvt42


using System;
namespace day5csharp
{
    class day5csharp
    {
        static void Main(string[] args)
        {
            string str, rser = "";
            int i, j;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            j = str.Length - 1;
            for (i = j; i >= 0; i--)
            {
                rser += str[i];
            }
            Console.WriteLine("The reverse order is : {0}", rser);
        }
    }
}


2. Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are
considered valid words.
The sentences always start by word and end by separator.
C# is not C++, and PHP is not Delphi!
Delphi not is PHP, and C++ not is C#!
The quick brown fox jumps over the lazy dog /Yes! Really!!!/.
Really Yes dog lazy the over jumps fox brown /quick! The!!!/.

using System;
namespace day5csharp
{
    class day5csharp
    {
        static void Main(string[] args)
        {
            Console.Write("Your words: ");
            string words = Console.ReadLine();
            string[] separ = words.Split(' ', '!', '.') ;
            Stack<string> res = new Stack<string>(separ);
            Console.Write("\nThe reserved words: ");

            for (int i = 0; i < separ.Length; i++)
            {
                Console.Write($"{res.Pop()} ");
            }
            Console.WriteLine("");
        }
    }
}

3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted
Hi,exe? ABBA! Hog fully a string: ExE. Bob
a, ABBA, exe, ExE


using System;
namespace day5csharp
{
    class day5csharp
    {
        static void Main(string[] args)
        {
            string str, pal = string.Empty;
            Console.Write("Enter a word : ");
            str = Console.ReadLine();

            if (str != null)
            {
                int len = str.Length - 1;
                for (int i = len; i >= 0; i--)
                {
                    pal += str[i].ToString();
                }
                if (pal == str)
                {
                    Console.WriteLine("The word " + pal + " is the palindrome ");
                }
                else
                {
                    Console.WriteLine("The word " + str + " is not the palindrome ");
                }
            }
            Console.ReadLine();
        }
    
    }
}


4. Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional.
https://www.apple.com/iphone
[protocol] = "https"
[server] = "www.apple.com"
[resource] = "iphone"
ftp://www.example.com/employee
[protocol] = "ftp"
[server] = "www.example.com"
[resource] = "employee"
https://google.com
[protocol] = "https"
[server] = "google.com"
[resource] = ""
www.apple.com
[protocol] = ""
[server] = "www.apple.com"
[resource] = ""


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace day5csharp
{
    class day5csharp
    {
        static void Main(string[] args)
        {
            String str = "ftp://www.example.com/employee";  //https://www.apple.com/iphone   https://google.com
            String[] arr = new String[3];                    //ftp://www.example.com/employee
            arr[0] = str.Substring(0, str.IndexOf("://"));
            if (str.LastIndexOf('/') == str.IndexOf('/') )
            {
                arr[1] = str.Substring(str.IndexOf("www") );
                arr[2] = "";
            }
            else
            {
                arr[1] = str.Substring(str.IndexOf("www"), str.LastIndexOf('/'));
                arr[2] = str.Substring(str.LastIndexOf('/') );
            }
            Console.WriteLine("[protocol] = " + arr[0]);
            Console.WriteLine("[server] = " + arr[1]);
            Console.WriteLine("[resource] = " + arr[2]);
        }

    }
}

*/
