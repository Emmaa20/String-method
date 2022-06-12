using System;
class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("press yes or no");
        string targetForm = Console.ReadLine();
        bool isCaseSensetive = false;

        if (targetForm == "yes")
        {
            isCaseSensetive = true;
        }
        else if (targetForm == "no")
        {
            isCaseSensetive = false;
        }
        while (true)
        {
            Console.WriteLine("Please insert text:");
            string targetName = Console.ReadLine();
            Console.WriteLine("Please insert character:");
            char targetChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("result:");
            Console.WriteLine(IsLetterExists(targetName, targetChar));
            Console.WriteLine(" ");
        }
        static bool IsLetterExists(string targetName, char targetChar)
        {
            for (int i = 0; i < targetName.Length; i++)
            {
                if (targetChar == targetName[i])
                {
                    return true;
                }

            }
            return false;
        }
    }
}