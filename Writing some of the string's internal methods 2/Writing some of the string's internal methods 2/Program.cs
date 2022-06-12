char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

char[] Lower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
while (true)
{
    Console.WriteLine("please insert char : ");
    string targetText = Console.ReadLine();
    string result = AlphabetChanger(targetText, Upper, Lower);
    Console.WriteLine($"Your changed name : {result}");

    Console.WriteLine("please insert char : ");
    string targetTextTwo = Console.ReadLine();
    string resultTwo = AlphabetChanger2(targetTextTwo, Lower, Upper);
    Console.WriteLine($"Your changed name : {resultTwo}");
}
static string AlphabetChanger(string Text, char[] upperAlphabet, char[] lowerAlphabet)
{
    for (int i = 0; i < upperAlphabet.Length; i++)
    {
        Text = Text.Replace(lowerAlphabet[i], upperAlphabet[i]);
    }
    return Text;
}

static string AlphabetChanger2(string Text, char[] lowerAlphabet, char[] upperAlphabet)
{
    for (int i = 0; i < lowerAlphabet.Length; i++)
    {
       Text = Text.Replace(upperAlphabet[i], lowerAlphabet[i]);
    }
    return Text;
}