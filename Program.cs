using OneWord;

Console.WriteLine("Enter word.");
var word = Console.ReadLine();
var length = word.Length;

#region task 5
Console.WriteLine(word.Reverse().ToArray());

var pair = Number.AskPair();
var X = pair.first;
var Y = pair.second;


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



#region change place of some chars

var powList = Number.AskOneToMakeArray(length);

var randList = new List<int>();
var randomizer = new Random();
for( int i=powList.Count; i >0 ; i--)
{
    var temp = randomizer.Next(i);
    randList.Add(powList[temp]);
    powList.RemoveAt(temp);
}

for (int i = 0; i < length; i++)
{
    if (randList.Contains(i))
    {
        Console.Write(word[randList[0]]);
        randList.RemoveAt(0);
    }
    else 
    {
        Console.Write(word[i]);
    }
}
#endregion

#region count chars
var tempCharList = new List<char>();
foreach (var ca in word)
{
    if (!tempCharList.Contains(ca))
    {
        tempCharList.Add(ca);
    }
}
Console.WriteLine($"Entered word contains {tempCharList.Count} different chars.");
#endregion

#region count Neighbours
var countNeighbours = 0;
for (int i = 0; i < length - 1; i++)
{
    if (word[i] == word[i + 1])
    {
        countNeighbours++;
    }
}
Console.WriteLine($"Amount of equal neighbours = {countNeighbours}");
#endregion


#endregion task 5