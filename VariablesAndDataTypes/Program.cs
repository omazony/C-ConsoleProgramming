

// Variable Declaration and Types

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool isWorking;



// User Input

Console.Write("Enter your Full Name: ");
fullName = Console.ReadLine();

Console.Write("Enter your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

//if user inputs Male transfer it to "M" or Female transfer it to "F"


Console.Write("Are you working? (true of false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());

// Output

//Output all the information provided by the user
Console.WriteLine("Your Full Name is: " + fullName); // concatinating string
Console.WriteLine("Your Age is: {0}" + age);
Console.WriteLine($"Your Salary is: {salary}"); // string interpolation
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed : {isWorking}");