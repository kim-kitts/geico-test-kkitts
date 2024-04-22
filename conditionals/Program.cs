// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
Control Flow - fundamental aspect of programming in which the developer adds in concepts 
to futher gain control over what will or will not happen within the program. And/or how often. 
Often a condition/check is used to assess whether or not a chinks  of cude will proceed.
    - Condition Boolean express
        -
        -
        -

conditional Statement - evalueats a condition to simply determine if a chunk of code is/is not executed

If statement
If Else statements
If elseIf Else statements
ternary operators
switch statements

switch-case statements
*/



//int number = 10;
//bool isRainy = true;

//////if (isRainy) 
//{
    //System.Console.WriteLine("It is Rainy outside!");

//}

//quick detour -> console input -> console readline
System.Console.WriteLine("Please enter your favorite number: ");
string? input = Console.ReadLine();

System.Console.WriteLine("Your favorite number is: " + input);


int number = 0; //we need to create the number variable outside of teh If STatement
//for it's 'scope' to stretch beyond just that If block
//Converting Data Types

if (input != null)
{
number = int.Parse(input);
}
else

{
    System.Console.WriteLine("You failed to enter only digits, you suck.");
    number = -1;
}

if (number > 10)
{
    System.Console.WriteLine("Your favorite number is greater than 10!");
}
else
{
    System.Console.WriteLine("Your favorite number is not greater than 10!");
}

//An alternative to nested conditionals
//if-elseif-else statements

if (number > 10)
{
    System.Console.WriteLine(">10 yay!");
}
else if (number > 5)
{
    System.Console.WriteLine("5 < your number <=10....yay...");
}
else{
    System.Console.WriteLine("<=5");
}

//Ternary Operators
//It is an Alternative to simple if-else statements where the tasks or outcomes are very similar
//(condition) ? <option of condition is true> ; <option if condition is false>

if (number > 10)
{
    System.Console.WriteLine("Your number is greater than 10");
}
else {
    System.Console.WriteLine("Your number is not greater than 10");
}

string phrase = "Your number is " + ((number > 10) ? "greater than 10" : "not greater than 10");
System.Console.WriteLine();

//switch case statements
//are best used when the option we want to consider are particular, finite, and/or incremental

/*
switch (variable)
{
    case(value1):
    {
        //some code to execture if variable == value1
    }
    case(value2):
    {
        //some code to execture if variable == value2
    }
    case(value3):
    case(value4):
    {
        //some code to execute if variable == value3 or vaule4
    }
    default:
    {
        //some code to execute if variable != to any other case*
    }
}
//------
*/

//-------------
System.Console.WriteLine("Enter an option 1-4 ");
input = Console.ReadLine();
int option = 0;

if (input != null) option = int.Parse(input);

switch (option)
{
    case 1:
    {
        System.Console.WriteLine("You have chosen option 1. You win $1.");
    }
    case 2:
    {
        System.Console.WriteLine("You have chosen option 2. You win $2.");
    }
    default:
    {
        System.Console.WriteLine("You did not choose an option 1-4. Please try againg.");
    }
}
