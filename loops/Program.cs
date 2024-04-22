// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Control Flow - Loops - allow us to execute a chunk of code for as long as a condition continues to be true
The condition is reassessed after each "iteration" of the loop, before executing the loop again.

- While Loop
        - Do-While Loop
        - Best used when the number of iterations needed by the loop is non known/ non-deterministic

- For Loop
        -For each Loop
        - Best used if the number of iterations by the loop is known or can be calculated. Finite.

*/

//Print the numbers 1-100
int counter = 1;

/*
while (condition)
{
    //code to execute while condition is true
}
*/
while (counter <= 100)
{
    System.Console.WriteLine(counter);
    counter++;
}

System.Console.WriteLine("End of Program");

//Print the sum of the numbers 1-1000
counter = 1;
int end = 1000;
int sum = 0;
while (counter <= end)
{
    sum += counter;
    counter++;
}
System.Console.WriteLine("The sum of the numbers 1-" + end + " is: "+ sum);


/*
Guessing Game - Make an new project
    - start with the assumed range of number 1-100
    - prompt the user to enter a number in said range
    - tell the user if the number is higher, lower, or equal to <some number of your choice>
        - if they are equal, they win the guessing game
        - if higher or lower, let them guess again
        - the while loop essentiall need to contain
            -
            prompting the user 
            - retrieving their guess
            - telling them hihger, lower or correct
            - while (guess != correctChoice) -> run the loop again.

            - bonuses
                - introduce yoruself to some Random class, to help you randomize the correct answer
                - the user is prompted to play again without having to restart the application
                    - involved (likely) another (outer) while loop


*/