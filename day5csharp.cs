/*
 * Day5 hw
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
*/