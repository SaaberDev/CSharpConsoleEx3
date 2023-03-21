namespace ConsoleEx3.ArrayAndList;

public class DetectUniqueNumber
{
    private const string Quit = "quit";
    
    public void DisplayResult()
    {
        var lists = new List<int>();
        while (true)
        {
            ASK_NUMBER:
            Console.WriteLine("Please enter a number.");
            var input = Console.ReadLine();

            if (input?.ToLower() == Quit)
            {
                Console.WriteLine("Thank you for participating.");
                break;
            }

            if (input != null && IsNotDigit(input))
            {
                Console.WriteLine("Only digits are allowed. Please retry.");
                goto ASK_NUMBER;
            }
            
            if (!lists.Contains(Convert.ToInt32(input)))
            {
                lists.Add(Convert.ToInt32(input));
            }
        }

        if (lists.Count == 0) return;
        var unique = string.Join(',', lists);
        Console.WriteLine($"Here are the unique numbers: {unique}");
    }

    /**
     * Check if input is digits only
     */
    private bool IsNotDigit(string value)
    {
        return value.Any(ch => ! char.IsDigit(ch));
    }
}