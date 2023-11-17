// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
//C# dilində Regex sinfi egular expressions işləmək üçün metodlar və xassələri təmin edir

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