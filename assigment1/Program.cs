// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

Console.WriteLine("Hello, World!");
//1.
Console.WriteLine("enter the number");

int X = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine(X);

//2.
string result = Console.ReadLine();

int num = int.Parse(result);
Console.WriteLine(num);

//3.
float A = 3.5f;
float B = 2.4f;
Console.WriteLine(A + B);

//4.
string myString = "Hello";
Console.WriteLine(myString[0]);

//5.
// number 2 take the first value of number 1
int number1 = 10;
int number2 = number1;
number1 =50 ;
Console.WriteLine(number2);

//6.
//num2 can't access the value from num1
long num1 = 7;
int num2 = num1;

//7.
string fname = "Sara";
string lname = "Rajab";
Console.WriteLine(fname+" "+lname);

//8.
Console.WriteLine("enter your principale");
Double principal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter your rate");
double rate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter your time");
Double time = Convert.ToDouble(Console.ReadLine());

double Interest=(principal * rate * time) / 100;

Console.WriteLine(Interest);

//9.
        Console.Write("Enter your weight : ");

        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height: ");

        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine("Your BMI is: " + bmi);

//10.

        int temperature = Convert.ToInt32(Console.ReadLine()); 
        string statues = (temperature < 10) ? "Just Cold" :
                        (temperature > 30) ? "Just Hot" :
                        "Just Good";
        Console.WriteLine("The temperature is: " + statues);
    
//11.

        Console.WriteLine("Enter the day (dd): ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the month (mm): ");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the year (yyyy): ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"Today's date : {day}, {month}, {year}");
        Console.WriteLine($"Today's date : {day} / {month} / {year}");
        Console.WriteLine($"Today's date : {day} – {month} – {year}");

//12.

DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
//The event is on 06/14/2024

//13.
int d;
d = Convert.ToInt32(!(30 < 20));
//The code reports an error.

//14.
Console.WriteLine(13 / 2 + " " + 13 % 2);
//61

//15.
int numm = 1, z = 5;


if (!(num <= 0))
    Console.WriteLine(++numm + z++ + " " + ++z);
else
    Console.WriteLine(--numm + z-- + " " + --z);
//7 7










