// Exercise 6:

{
    bool userAgree1 = false;
    do
    {
        Console.WriteLine("Hello would!");
        Console.WriteLine("Would you like to continue? (y/n)");
        string userInput1 = Console.ReadLine().ToLower();
        if (userInput1 == "y")
        {
            userAgree1 = true;
        }
        else
        {
            break;
        }
    } while (userAgree1 == true);
}

// Exercise 7:

{
    bool userAgree2 = false;
    do
    {
        Console.WriteLine("Type something and I'll repeat it back to you.");
        string userInput2 = Console.ReadLine();
        Console.WriteLine(userInput2);
        Console.WriteLine("Would you like to continue? (y/n)");
        string userInput3 = Console.ReadLine().ToLower();
        if (userInput3 == "y")
        {
            userAgree2 = true;
        }
        else
        {
            break;
        }
    } while (userAgree2 = true);
}

// Exercise 8: - skipping, asking to code a do-while loop of exercises 2-5 (other VS project)

// Exercise 9:

Console.WriteLine("Please enter a language - English, Spanish, French, or German");
string userLanguage = Console.ReadLine().ToLower();
switch (userLanguage)
{
    case "english":
        Console.WriteLine("Hello World!");
        break;
    case "spanish":
        Console.WriteLine("Hola Mundo!");
        break;
    case "french":
        Console.WriteLine("Bonjour le monde!");
        break;
    case "german":
        Console.WriteLine("Hello Welt!");
        break;
}

// Exercise 10:

Console.WriteLine("Please enter your height in inches");
string userInput4 = Console.ReadLine();
decimal userHeight = 0;
bool validHeight = decimal.TryParse(userInput4, out userHeight);
while (validHeight == false)
{
    Console.WriteLine("Incorrect input. Please enter a number");
    userInput4 = Console.ReadLine();
    validHeight = decimal.TryParse(userInput4, out userHeight);
}
if (userHeight >= 54)
{
    Console.WriteLine("Great! You can ride the Raptor!");
}
else
{
    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {(54 - userHeight)} more inches");
}

// Exercise 11:

Console.WriteLine("Press any key to see the output of all numbers from 0-9");
Console.ReadKey();
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Exercise 12:

Console.WriteLine("Press any key to see the output of all numbers from 9-0");
Console.ReadKey();
Console.WriteLine();
for (int i = 9; i >= 0; i--)
{
    Console.WriteLine(i);
}

// Exercise 13:

Console.WriteLine("Please enter a number");
string userInput5 = Console.ReadLine();
int userNumber5 = 0;
bool validNumber5 = int.TryParse(userInput5, out userNumber5);
for (int i = userNumber5; i >= 0; i--)
{
    Console.WriteLine(i);
}

// Exercise 14:

Console.WriteLine("Please enter a number");
string userInput6 = Console.ReadLine();
int userNumber6 = 0;
bool validNumber6 = int.TryParse(userInput6, out userNumber6);
for (int i = 1; i <= userNumber6; i++)
{
    int square = i * i;
    Console.WriteLine(square);
}

// Exercise 15:

Console.WriteLine("Please enter a number");
string userInput7 = Console.ReadLine();
int userNumber7 = 0;
bool validNumber7 = int.TryParse(userInput7, out userNumber7);
for (int i = 1; i <= userNumber7; i++)
{
    int cube = i * i * i;
    Console.WriteLine(cube);
}

// Exercise 16:

Console.WriteLine("Press any key to see the output of a half triangle of astericks with a height of 10");
Console.ReadKey();
Console.WriteLine();
int rows = 10;
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Exercise 17:

Console.WriteLine("Press any key to see the output of a triangle of astericks with a height of 10");
Console.ReadKey();
Console.WriteLine();
int triangleRows = 10;
for (int i = 1; i <= triangleRows; i++)
{
    for (int j = 1; j <= triangleRows - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// Exercise 18:

Console.WriteLine("Enter a number to see the sum of all the numbers from 1 to the number entered.");
string userNumberTotal = Console.ReadLine();
int numberTotal1 = 0;
int totalSum1 = 0;
bool validUserNumberTotal = int.TryParse(userNumberTotal, out numberTotal1);
for (int i = 1; i <= numberTotal1; i++)
{
    totalSum1 += i;
}
Console.WriteLine(totalSum1);

// Exercise 19:

Console.WriteLine("Please enter the first number to see the sum of all the numbers from the first number to the second");
int userNumber8 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second number to see the sum of all the numbers from the first number to the second");
int userNumber9 = int.Parse(Console.ReadLine());
int totalSum8 = 0;
for (int i = userNumber8; i <= userNumber9; i++)
{
    totalSum8 += i; // same as writing totalSum8 = totalSum8 + i
}
Console.WriteLine($"The sum of all the numbers from {userNumber8} to {userNumber9} is {totalSum8}");

// Exercise 20:

Console.WriteLine("Enter a number and I will calculate the product of the number and the two preceding numbers");
int userNumber10 = int.Parse(Console.ReadLine());
int product = 1;
for (int i = userNumber10; i >= (userNumber10 - 2); i--)
{
    product *= i; // same as writing product = product * i
}
Console.WriteLine($"The product of {userNumber10}, {userNumber10 - 1}, and {userNumber10 - 2} equals {product}");

// Exercise 21:

string sentence = "";
string continueInput = "y";
while (continueInput.ToLower() == "y")
{
    sentence = "";
    bool addMoreWords = true;
    while (addMoreWords == true)
    {
        Console.Write("Enter a word");
        Console.WriteLine();
        string word = Console.ReadLine();
        if (sentence == "")
        {
            sentence = word;
        }
        else
        {
            sentence = sentence + " " + word;
        }
        Console.Write("Would you like to enter another word? (y/n)");
        string anotherWord = Console.ReadLine().ToLower();
        if (anotherWord != "y")
        {
            addMoreWords = false;
        }
    }
    Console.WriteLine("Your sentence: " + sentence + ".");
    Console.Write("Would you like to continue? (y/n)");
    continueInput = Console.ReadLine().ToLower();
}
Console.WriteLine("Goodbye!");

// Exercise 22:

int startRange, endRange;
string continuePlay = "y";

Console.Write("Enter a number");
Console.WriteLine();
startRange = int.Parse(Console.ReadLine());

Console.Write("Enter another number");
endRange = int.Parse(Console.ReadLine());

Console.WriteLine($"Your range is {startRange}-{endRange}.");

while (continuePlay == "y")
{
    Console.Write("Enter a number to verify if it is in the range");
    int numberToVerify = int.Parse(Console.ReadLine());
    if (numberToVerify >= startRange && numberToVerify <= endRange)
    {
        Console.WriteLine($"{numberToVerify} is in the range");
    }
    else
    {
        Console.WriteLine($"{numberToVerify} is outside the range");
    }
    Console.Write("Would you like to continue? (y/n)");
    continuePlay = Console.ReadLine().ToLower();
}
Console.WriteLine("Goodbye!");




