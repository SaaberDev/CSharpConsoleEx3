namespace ConsoleEx3.ArrayAndList;

public class ArrayReverse
{
    public void DisplayResult()
    {
        Console.WriteLine("Please enter your name.");
        var name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            var nameLength = name.Length;
            var setNameInNewArray = new char[nameLength];

            for (var i = nameLength; i > 0; i--)
            {
                setNameInNewArray[nameLength - i] = name[i - 1];
            }
            
            var reversed = new string(setNameInNewArray);
            Console.WriteLine($"Reversed name is: {reversed}");
        }
        else
        {
            Console.WriteLine();
        }
    }
}