namespace ConsoleEx3.ArrayAndList;

public class FacebookLike
{
    public void DisplayResult()
    {
        ASK_QUESTION:
        Console.WriteLine("Please enter different names and submit.");
        Console.WriteLine("*** When you are done press ENTER (without supplying a name) ***");
        var names = new List<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input != null && IsNotLetter(input))
            {
                Console.WriteLine("Name must contain letters only.");
                goto ASK_QUESTION;
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            names.Add(input);
        }

        var totalNames = names.Count;
        
        switch (totalNames)
        {
            case > 2:
                Console.WriteLine($"{names[0] + ", " + names[1] + " and " + (totalNames - 2)} others like your post.");
                break;
            case 2:
                Console.WriteLine($"{names[0] + " and " + names[1]} like your post.");
                break;
            case 1:
                Console.WriteLine($"{names[0]} likes your post.");
                break;
            default:
                Console.WriteLine();
                break;
        }
    }
    
    /**
     * Check if input is digits only
     */
    private bool IsNotLetter(string value)
    {
        return value.Any(ch => ! char.IsLetter(ch));
    }
}