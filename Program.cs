using OneWord;

Console.WriteLine("Important message: Counting of symbols in word begins from 0.");

Console.WriteLine("Enter word.");
var word = Console.ReadLine();
var length = word.Length;

//write the inversion of the entered word
Console.WriteLine(Word.Reverse(word));

//preparation of some integer numbers for nest task
var pair = Number.AskPair();
var X = pair.first;
var Y = pair.second;

//show certain char of inputed word
Word.GetCertainChar(word,X);

//define equity of certain chars and write both of this chars
Word.DefineEqity(word,X,Y);

//Change some chars in word
Word.SwapPlaces(word);

//define amount of different chars in word
Word.Neighbours(word);

//Operations with half of the word
Word.HalfOperations(word);