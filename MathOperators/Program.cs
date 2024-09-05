//See : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/operators-and-expressions/operators


//Basic Assignment Operator

int num = 5;

//Arithmetic Operators

int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: { num1 + num2} "); //Addition
Console.WriteLine($"Subtraction: {num1 - num2} "); //Subtraction
Console.WriteLine($"Multiplication: {num1 * num2} "); //Multiplication
Console.WriteLine($"Division: {num1 / num2} "); //Division
Console.WriteLine($"Modulus: {num1 % num2} "); //Modulus

num1 = num1 + 4; // or write as num1 += 4;


Console.WriteLine($"New Value of num1: {num1} "); //New Value
Console.WriteLine($"Addition: {num1 + num2} "); //Addition
Console.WriteLine($"Subtraction: {num1 - num2} "); //Subtraction
Console.WriteLine($"Multiplication: {num1 * num2} "); //Multiplication
Console.WriteLine($"Division: {num1 / num2} "); //Division
Console.WriteLine($"Modulus: {num1 % num2} "); //Modulus

// Compound Assignment Operators

num1 += 4; // num1 = num1 + 4;
Console.WriteLine($"New Value of num1: {num1} "); //New Value
num1 -= 4; // num1 = num1 - 4;
Console.WriteLine($"New Value of num1: {num1} "); //New Value
num1 *= 4; // num1 = num1 * 4;
Console.WriteLine($"New Value of num1: {num1} "); //New Value
num1 /= 4; // num1 = num1 / 4;
Console.WriteLine($"New Value of num1: {num1} "); //New Value
num1 %= 4; // num1 = num1 % 4;
Console.WriteLine($"New Value of num1: {num1} "); //New Value
