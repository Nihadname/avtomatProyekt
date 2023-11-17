// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
#region regex //C# dilində Regex sinfi egular expressions işləmək üçün metodlar və xassələri təmin edir
#region Pattern matching
//Pattern matching
//sətir daxilində xüsusi simvol ardıcıllığına uyğunlaşmaq üçün xüsusi simvol və konstruksiyalardan istifadə edərək nümunələri müəyyən etməyə imkan verir.
//burda m ile baslayanlari goturur
string pattern = @"\b[M]\w+";
// bu regex qurur
Regex rg = new Regex(pattern);

// Long string
string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";
// Get all matches
MatchCollection matchedAuthors = rg.Matches(authors);
for (int i = 0; i < matchedAuthors.Count;i++)
    Console.WriteLine(matchedAuthors[i].Value);
#endregion
#region Searching and replacing
//Searching and replacing
//Siz sətir daxilində nümunələri axtarmaq və onları başqa mətnlə əvəz etmək və ya sətirin uyğun hissələrini manipulyasiya etmək üçün regexdən istifadə edə bilərsiniz.
// A long string with a ton of white spaces
string badString = "Here is a strig with ton of white space.";
string CleanedString = Regex.Replace(badString, "\\s+", " ");//bu s+  bos erazilerden qurtulmaq ucun
Console.WriteLine($"Cleaned String: {CleanedString}");
#endregion
#region Regular Expressions
//Regular Expressions
Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
//class Regex represents an immutable regular expression.

string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
//Input strings for Match valid mobile number.
foreach (string s in str)
{
    Console.WriteLine("{0} {1} a valid mobile number.", s,
    r.IsMatch(s) ? "is" : "is not");
    //burda isMatch yoxluyurki goren string bunun qaydalarina emel qoyurmu 
}
#endregion
#region Validation
//Validation
//Siz daxiletmənin uyğun olması lazım olan nümunəni təyin edə və sonra giriş sətirinin həmin nümunəyə uyğun olub olmadığını yoxlamaga imkan verir
Console.WriteLine("emailinizi girin");
string userInput = Console.ReadLine();
string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
Regex regex = new Regex(emailPattern);
if (regex.IsMatch(userInput))
{
    Console.WriteLine(" bu qebul olunan emaildir");
}
else
{
    Console.WriteLine("qebul olunmayan eamil");
}
string sentence = "Hello! How are you? I'm doing fine.";

string pattern1 = @"[\p{P}\p{Z}]"; //butun durgu isaresine ve bosluga uygun gelen pattern 

string[] words = Regex.Split(sentence, pattern1);// burda hisseye bolur

foreach(string word in words)
{
    if (!string.IsNullOrWhiteSpace(word)) // bosluglari ortadan cixarir qoymur
    {
        Console.WriteLine(word);
    }
}
#endregion
#endregion
#region Math
//The Math.Max(x,y) method can be used to find the highest value of x and y:

Math.Max(5, 10);//10 
                //The Math.Min(x,y) method can be used to find the lowest value of of x and y:
Console.WriteLine(Math.Min(5, 10));
//The Math.Sqrt(x) method returns the square root of x:
Math.Sqrt(64);//8 di
              //The Math.Abs(x) method returns the absolute (positive) value of x:
Math.Abs(-4.7);//4.7 olcaq
//Math.Round() rounds a number to the nearest whole number:
Math.Round(9.99);//10
// Raises a number to a specified power.
double powerValue = Math.Pow(2, 3); //8
Console.WriteLine(powerValue);

#endregion