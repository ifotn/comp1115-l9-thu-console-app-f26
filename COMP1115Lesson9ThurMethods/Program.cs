/// <summary>
/// Adds 2 integers
/// </summary>
/// <param name="x">First int</param>
/// <param name="y">Second int</param>
/// <returns>Sum of 2 ints</returns>
int AddNumbers(int x, int y)
{
    return x + y;
}

// call the method
int sum = AddNumbers(10, 12);
Console.WriteLine($"sum: {sum}");

// "void" return type: method doesn't return any value back to calling code
/// <summary>
/// Displays message that includes string input value
/// <param name="name">Name to show in output</param>
/// <returns>{Nothing}</returns>
/// </summary>
void ShowMessage(string name)
{
    Console.WriteLine($"Hello {name}");
}

// call the method
ShowMessage("Rich");
ShowMessage("Tom");

/// <summary>
/// Doubles a # and shows the result
/// </summary>
/// <param name="x">A # to double</param>
/// <returns>{Nothing}</returns>
void DoubleIt(int x)
{
    x = x * 2;
    Console.WriteLine(x);
}

int x = 10;
DoubleIt(x);  // a copy of x is passed, the original value of x is still 10
Console.WriteLine(x);  // will this show 10 or 20?  x is still 10 - original value unchanged