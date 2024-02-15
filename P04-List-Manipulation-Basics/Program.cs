List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandElements = command.Split().ToArray();

    if (commandElements[0] == "Add")
    {
        int element = int.Parse(commandElements[1]);

            numbers.Add(element);
    }
    else if (commandElements[0] == "Remove")
    {
        int element = int.Parse(commandElements[1]);

        numbers.Remove(element);
    }
    else if (commandElements[0] == "RemoveAt")
    {
        int position = int.Parse(commandElements[1]);

        numbers.RemoveAt(position);
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

