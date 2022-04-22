using OneWord;

Console.WriteLine("Enter word.");
var word = Console.ReadLine();
Console.WriteLine(word.Reverse().ToArray());

var pair = Number.AskPair();
var X = pair.first;
var Y = pair.second;

var length = word.Length;
Console.WriteLine("Counting of symbols in word begins from 0.");
if (length-1 < X)
{
    Console.WriteLine($"Can't show you symbol number {X} because entered word is too short.");
}
else
{
    Console.WriteLine($"Char number {X} = {word[X]}");
}

if (length - 1 >= Y)
{
    var isEqual = word[X].Equals(word[Y]);
    if (isEqual)
    {
        Console.WriteLine($"Symbols {X} and {Y} is eqal.");
    }
    else
    {
        Console.WriteLine($"Symbols {X} and {Y} are not euqal.");
    }
    Console.WriteLine($"Concatination of this two symbols = {word[X]}{word[Y]}.");
}
else
{
    Console.WriteLine($"Can't definite equity of symbol {X} and {Y} because entered word is too short.");
}

X = Number.AskOne();
var i = 0;
var numbers = new List<int>();
do
{
    var temp =(int) Math.Pow(X, i);
    if (temp <= length - 1)
    {
        numbers.Add(temp);
        i++;
    }
    else
    {
        break;
    }
}
while (true);

