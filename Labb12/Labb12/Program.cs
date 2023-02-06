using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your string here:");
        string UserInput = Console.ReadLine();

        for (int Start = 0; Start < UserInput.Length - 1; Start++)
        {
            for (int End = UserInput.Length - 1; End > Start; End--)
            {
                if (UserInput[Start] == UserInput[End])
                {
                    bool isValid = true;
                    for (int i = Start + 1; i < End; i++)
                    {
                        if (UserInput[i] == UserInput[Start] || !char.IsDigit(UserInput[i]))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Result(UserInput, Start, End);
                    }
                }
            }
        }
    }

    public static void Result(string original, int fromIndex, int toIndex)
    {
        var OriginalColor = Console.ForegroundColor;
        Console.Write(original.Substring(0, fromIndex));
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(original.Substring(fromIndex, toIndex - fromIndex + 1));
        Console.ForegroundColor = OriginalColor;
        if (toIndex < original.Length - 1)
            Console.Write(original.Substring(toIndex + 1));
        Console.WriteLine();
    }
}