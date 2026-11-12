using System.Xml.Linq;

/// <summary>
/// 1: Adds 2 integers
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
/// 2: Displays message that includes string input value
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
/// 3: Doubles a # and shows the result
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

/// <summary>
/// 4a: Print Banner that includes title param
/// </summary>
/// <param name="title">title to include</param>
/// <returns>{Nothing}</returns>
void PrintBanner(string title)
{
    Console.WriteLine($"***{title}***");
}

PrintBanner("It's Thursday!");
PrintBanner("Tomorrow is Friday!");

/// <summary>
/// 4b: Calculate & display average of 2 #'s
/// </summary>
/// <param name="x">1st int</param>
/// <param name="y">2nd int</param>
/// <returns>Avg of 2 ints</returns>
int Average(int x, int y)
{
    return (x + y) / 2;
}

int avg = Average(20, 12); 
Console.WriteLine($"Average: {avg}");

/// <summary>
/// 4c: Show greeting in different languages
/// </summary>
/// <param name="name">name to include in greeting</param>
/// <param name="language">language to display greeting</param>
/// <returns>a greeting</returns>
string BuildGreeting(string name, string language)
{
    if (language.ToLower() == "english") { return $"Hello, {name}."; }
    if (language.ToLower() == "spanish") { return $"Ola, {name}."; }
    if (language.ToLower() == "italian") { return $"Ciao, {name}."; }
    return "invalid language";
}

Console.WriteLine(BuildGreeting("Jess", "english"));
Console.WriteLine(BuildGreeting("Javier", "spanish"));
Console.WriteLine(BuildGreeting("Franco", "italian"));

/// <summary>
/// 4d: did user get passing score?
/// </summary>
/// <param name="score">user score</param>
/// <returns>true / false => did user pass?</returns>
bool IsPassing(int score)
{
    if (score >= 50) { return true; }
    else { return false; }
}

bool result = IsPassing(51);
Console.WriteLine($"Score of 51 gives passing result: {result}");
result = IsPassing(49);
Console.WriteLine($"Score of 49 gives passing result: {result}");