static void Main(string[] args)
{
    char[] TargetUpperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    char[] TargetLowerCaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    while (true)
    {
        string[] commands = { "/Convert to uppercase letters", "/Convert to lowercase letters", "/determine the existence of a letter" };
        Console.WriteLine("/Convert to uppercase letters");
        Console.WriteLine("/Convert to lowercase letters");
        Console.WriteLine("/determine the existence of a letter");
        Console.WriteLine("please choose a command from above:");
        string command = Console.ReadLine();
    }
}
