Console.Write("Enter the length for the initial array: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0)
{
    string[] InitialStringArray = new string[size];
    
    for (int i = 0; i < InitialStringArray.Length; i++)
    {
        Console.Write($"Enter string {i + 1}: ");
        InitialStringArray[i] = Console.ReadLine();
    }

    string[] ResultingStringArray = InitialStringArray.Where(s => s.Length <= 3).ToArray();

    if (ResultingStringArray.Length > 0)
    {
        Console.Write("Result array -> [");
        for (int i = 0; i < ResultingStringArray.Length; i++)
        {
            Console.Write($"\"{ResultingStringArray[i]}\"");
            if (i != ResultingStringArray.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
    else Console.WriteLine("This array contains no strings containing three or less characters.");
}
else Console.WriteLine("The length of the array must be greater than zero.");