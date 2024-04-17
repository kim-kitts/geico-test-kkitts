// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numberOfBooks; //Variables should be in camelCasing

//Variable Assignment
//Syntax: variableName = some-value;
numberOfBooks = 10;
numberOfBooks = 11; //Re-assignment

Console.WriteLine(numberOfBooks);
Console.WriteLine(10);

// Variable Declaration and Assignment
double money = 2.50;
System.Console.WriteLine(money); //CW - shortcut - hit enter
                            //Don't stress over the System. preface


// = -> Assignment Operator

// Basic Operations:
int num = 1 + 2;
num = 1 - 2;
num = 1 * 3;
num = 1 / 3; // Integer Division
//num = 1 % 3; // Modulus

System.Console.WriteLine(num);

double num2 = 1 / 3.0;
System.Console.WriteLine(num2);
System.Console.WriteLine(1 / 3.0);
System.Console.WriteLine(0.1 + 0.2);



//Augmented (Compound) Assignment Operators

//What if I want to perfomr a calculation on a variable AND store that 
//result back into the variable.

int num3 = 10;
// in result = num3 * 3;
num3 = num3 + 5;
System.Console.WriteLine(num3);
System.Console.WriteLine(num3 + 5);
System.Console.WriteLine(num3);
// int result = num3 * 3;
num3 = num3 + 5;

//Augmented Assignement Operator
num3 += 5; // exactly the same as: num3 = num3 + 5;
num3 -= 10;
num3 *= 2;
num3 /= 2;
num3 %= 2;

System.Console.WriteLine(num3);

// Increment / Decrement Operators
num3++; // Increment - Add exactly 1    -> num3 += 1   -> num3 = num3 + 1
num3--; // Decrement - Subtracts exactly 1    -> num3 -= 1   -> num3 = num3 - 1

++num3;
--num3;

System.Console.WriteLine(num3);

System.Console.WriteLine(num3++); // Post-Increment
System.Console.WriteLine(num3);
System.Console.WriteLine(++num3); // Pre-Increment


// Booleans - value -type that stores either 'true' or 'false'

bool isSunny = true;
bool isRainy = false;

System.Console.WriteLine(isSunny);


// ! -> Negation Operator -> change the boolean into it's 'opposite' value
System.Console.WriteLine(!isSunny);

isSunny = !isSunny; // A Toggle -> switch isSunny's value to the other boolean value
System.Console.WriteLine(isSunny);


// Relational Operators - compar one value to another value. - Binary Operator
// ==, 1=, <, >, <=, >=

System.Console.WriteLine(5 == 5);
// 5 == 5 -> Boolean Expression -> expression taht evalueates to True or False
System.Console.WriteLine(numberOfBooks == 5);

System.Console.WriteLine(numberOfBooks != 5);
System.Console.WriteLine(numberOfBooks > 5);
System.Console.WriteLine(numberOfBooks < 5);
System.Console.WriteLine(numberOfBooks >= 5);
System.Console.WriteLine(numberOfBooks <= 5);
