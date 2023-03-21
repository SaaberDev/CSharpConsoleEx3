namespace ConsoleEx3.ArrayAndList;

public class StrictArrayLimit
{
    public void DisplayResult()
    {
        ASK_NUMBERS:
        Console.WriteLine("Please enter a list of comma-separated numbers.");
        var input = Console.ReadLine();
        var lists = input?.Split(',');

        if (lists is { Length: 0 or < 5 })
        {
            Console.WriteLine("Invalid List. Please retry.");
            goto ASK_NUMBERS;
        }
        
        // convert to numbers
        var numbers = new List<int>();
        if (lists != null)
        {
            foreach (var item in lists)
            {
                numbers.Add(Convert.ToInt32(item));
            }
        }
        
        // get the 3 smallest number
        numbers.Sort();
        var getRange = numbers.GetRange(0, 3);
        var smallest = string.Join(',', getRange);
        
        Console.WriteLine($"Here are the smallest 3 numbers: {smallest}");
    }
}