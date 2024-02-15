List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandElements = command.Split().ToArray();

    if (commandElements[0] == "Contains")
    {
        int element = int.Parse(commandElements[1]);

        if (numbers.Contains(element))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }

    else if (commandElements[0] == "PrintEven")
    {
        List<int> evenNumbers = new List<int>();    

        foreach (int element in numbers)
        {
            if (element % 2 == 0) 
            {
                evenNumbers.Add(element);
            }
        }
        Console.WriteLine(string.Join(" ", evenNumbers));
    }
    else if (commandElements[0] == "PrintOdd")
    {
        foreach (int element in numbers)
        {
            if (element % 2 != 0)
            {
                Console.Write(element + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandElements[0] == "GetSum")
    {
        int sum = 0;

        foreach (int element in numbers) 
        {
            sum += element;
        }
        Console.WriteLine(sum);
    }
    else if (commandElements[0] == "Filter")
    {
       string condition = commandElements[1];
       int inputNumber = int.Parse(commandElements[2]);

        List<int> filteredNumbers = new List<int>();

        foreach (int element in numbers)
        {
            if (condition == ">" && element > inputNumber)
            {
                filteredNumbers.Add(element);
            }
            else if (condition == "<" && element < inputNumber)
            {
                filteredNumbers.Add(element);
            }
            else if (condition == ">=" && element >= inputNumber)
            {
                filteredNumbers.Add(element);
            }
            else if (condition == "<=" && element <= inputNumber)
            {
                filteredNumbers.Add(element);
            }
        }
        numbers = filteredNumbers;
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));


