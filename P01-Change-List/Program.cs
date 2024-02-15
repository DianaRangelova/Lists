List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandElements = command.Split().ToArray();

    if (commandElements[0] == "Delete")
    {
        int element = int.Parse(commandElements[1]);

        while (numbers.Contains(element))
        {
            numbers.Remove(element);
        }
    }
    else if (commandElements[0] == "Insert")
    {
        int element = int.Parse(commandElements[1]);
        int position = int.Parse(commandElements[2]);

        numbers.Insert(position, element);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
