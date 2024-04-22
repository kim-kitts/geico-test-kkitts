// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");




//Creat a string variable
string word = "Hello";
System.Console.WriteLine(word);

//to access fields and mthods from objects we create we use the "." (member ac????)

word = "hi!";
System.Console.WriteLine(word.Length);

System.Console.WriteLine(word.ToUpper());
System.Console.WriteLine(word.ToLower());


//ToUpper();
//WriteLine(word); // Argument
//When defining a Method: referred to as the method's Parameters

word = "Hello World!";
System.Console.WriteLine(word.Length);
System.Console.WriteLine(word.Substring(0));


/*
    Indexes - Strings and other various collection-based devices use Indexes/Indexing

    Indexes describe the position of that element within the entire set of data.
    Strings -> teh position of that character withint the entire String.

    Indexes (in MOST programming languages) are 0-indexed.
    The first character in the string starts at index 0
        - The second character is at index 1, etc.....
        - The Last Index of any String is: Length - 1


*/


System.Console.WriteLine(word.Substring(6));
System.Console.WriteLine(word.Substring(6, 2));
//System.Console.WriteLine(word.Substring(6, 10)); //ArugmentOUtOfRangeException



// String Concatenation
// When using the "+" sign with Strings beahaiveor changes away from (mathmatical) addition.
//concatenation - the combiningin fo two omre more strings in which conjoin all the characteraosihsdfksaeoiowjsint into one snew string


string phrase ="Hello " + "World!";
System.Console.WriteLine(phrase);

string fname = "Queen";
string lname = "B";
System.Console.WriteLine("Hello, My Name is: " + fname + " " + lname + "!");

int num1 = 1;
int num2 = 2;
System.Console.WriteLine("Num1 = " + num1);
System.Console.WriteLine("Num2 = " + num2);

System.Console.WriteLine("1" + 1); //performs concatenation, not addition!

// value-types -> == measures if they have same value.
System.Console.WriteLine(num1 == 1);

num2 = 1;
System.Console.WriteLine(num1 == num2);

//reference-types - Objects -> == this will check if tye are the SAME Object type
Object obj1 = new();
Object obj2 = new();

System.Console.WriteLine(obj1 == obj2);
System.Console.WriteLine(obj1.Equals(obj2));

string word1 = "Hello";
string word2 = "Hello";
System.Console.WriteLine(word1 == word2);
// Strings utilize what is called a String Pool
// Strings that arte assigned the same value will point the same location in memory
//This is done to conserve on memory strings.

word2 = "Hey";




