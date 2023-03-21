namespace ConsoleEx3.ArrayAndList;

public class ForceInputUniqueNumber
{
    public void DisplayResult()
    {
        Console.WriteLine("Please enter five unique numbers.");
        var numbers = new List<int>();
        while (numbers.Count < 5)
        {
            ASK_NUMBER:
            var input = Console.ReadLine();
            if (input != null && IsNotDigit(input))
            {
                Console.WriteLine("Only digits are allowed.");
                goto ASK_NUMBER;
            }
            
            var number = Convert.ToInt32(input);
            if (numbers.Contains(number))
            {
                Console.WriteLine($"The number {number} already exist. Try again.");
                goto ASK_NUMBER;
            }
            numbers.Add(number);
        }

        numbers.Sort();
        
        var uniqueNumbers = string.Join(',', numbers);
        
        Console.WriteLine($"Here are the five unique numbers: {uniqueNumbers}");
    }
    
    /**
     * Check if input is digits only
     */
    private bool IsNotDigit(string value)
    {
        return value.Any(ch => ! char.IsDigit(ch));
    }
}