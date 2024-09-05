// See https://aka.ms/new-console-template for more information



Console.WriteLine("Enter Number of Apples : ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number of Oranges : ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());


// If Statements (==, !=, >, <, >=, <=)
if(numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more oranges");
}
else
{
    Console.WriteLine("You have equal number of apples and oranges");
}

// == equivalent to
// != not equal to
// > greater than
// < less than
// >= greater than or equal to
// <= less than or equal to



// Switch Statements (case, break, default)

Console.WriteLine("Enter final grade : ");
int finalGrade = Convert.ToInt32(Console.ReadLine());

switch(finalGrade)
{
    case int n when (n <= 60 && n > 0):
        Console.WriteLine("You Failed");
        break;
    case int n when n > 60 && n <= 100:
        Console.WriteLine("You Passed");
        break;
    case int n when n > 100:
        Console.WriteLine("The number needs to be below 100");
        break;

    default:
        Console.WriteLine("Invalid Grade");
        break;
}



// Ternary Operator (condition ? first_expression : second_expression;)

var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";
Console.WriteLine(message);
