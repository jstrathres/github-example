// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");


//This is a comment
//Console.WriteLine("I am active");

/*we can add long comments
 * Author:Josh Strathres
 * Date: 1/9/23
 */

//x is being declared
int x;

//x is being initialized
x = 10;

//combined
int y = 5;

// Constant 
const double TAXRATE = 0.06;
//TAXRATE = 1; cannot change a constant

//example
Console.WriteLine("please enter a radius");
//ReadLine usually used, waits for value from user
string result = Console.ReadLine();
//converts user input to a number
double num = double.Parse(result);
//Math.PI pulls full Pi value from database
//double num double.Parse(Console.ReadLine());  Faster way to do so but come back to this 
double area = num * num * Math.PI;
//string takes info with readline, double converts to number and writeline says it back
Console.WriteLine(area);

//NULL = nothing
string myName = null;
//cw + TAB TAB
Console.WriteLine(myName);
//Tom is defined here, reverts to else if statement
string friend = "Tom";

//friend = Josh
//family = IceMan
if (friend == "Family")
{
    myName = "Joshua";
}
else if (friend == "Tom")
{
    myName = "IceMan";
}
Console.WriteLine(myName);