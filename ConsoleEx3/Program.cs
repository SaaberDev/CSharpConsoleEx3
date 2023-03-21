using ConsoleEx3.ArrayAndList;

Console.Write(@"1. Facebook Like
2. Array Reverse
3. Force User To Input Unique Numbers
4. Unique Number Detection
5. Force User To Enter 5 Numbers And Display Only Smallest 3 Numbers
");
Console.WriteLine("=============================");
Console.WriteLine("Please choose a program between 1 and 5.");

var program = Convert.ToInt16(Console.ReadLine());

switch (program)
{
    case 1:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 1: Facebook Like");
        // continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        // depending on the number of names provided, display a message based on the below pattern.
        /*
         * here is the pattern:
         * 
         * 1. if no one likes your post, it doesn't display anything.
         * 2. if only one person likes your post, it displays: [Friend's Name] likes your post.
         * 3. if two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
         * 4. if more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.\
         */
        new FacebookLike().DisplayResult();
    break;
    
    case 2:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 2: Array Reverse");
        // ask the user to enter their name.
        // reverse the name using array reverse.
        new ArrayReverse().DisplayResult();
    break;
    
    case 3:
        Console.WriteLine("=============================");
        // ask the user to enter 5 numbers.
        // if a number has been previously entered, display an error message and ask the user to re-try.
        // once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        Console.WriteLine("Program 3: Force User To Input Unique Numbers");
        new ForceInputUniqueNumber().DisplayResult();
    break;
    
    case 4:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 4: Unique Number Detection");
        // ask the user to continuously enter a number or type "quit" to exit.
        // the list of numbers may include duplicates.
        // display the unique numbers that the user has entered.
        new DetectUniqueNumber().DisplayResult();
        break;
    
    case 5:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 5: Force User To Enter 5 Numbers And Display Only Smallest 3 Numbers");
        // ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        // if the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        new StrictArrayLimit().DisplayResult();
        break;
    
    default:
        Console.WriteLine("You did not choose any program.");
        break;
}