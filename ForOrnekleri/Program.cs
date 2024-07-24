//writes "Kendime inanıyorum, ben bu yazılım işini hallederim!" 10 times:
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

//writes numbers from 1 to 20 with comma in between:
Console.WriteLine("");
Console.WriteLine("1 ile 20 arasındaki sayılar:");
for (int i = 1; i < 21; i++)
{
    if (i == 20)
    {
        Console.Write($"{i}");
    }
    else
    {
        Console.Write($"{i}, ");
    }
}

//writes even numbers between 1 and 20 with comma in between:
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("1 ile 20 arasındaki çift sayılar:");
for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0)
    {
        if (i == 20)
        {
            Console.Write($"{i}");
        }
        else
        {
            Console.Write($"{i}, ");
        }
    }
}


//defined a variable num = 0, and added every number from 50 to 150:
int sum = 0;
for (int i = 50; i < 151; i++)
{
    sum = sum + i;
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}'dır.");

//defined to variables to hold odd and even numbers seperately and added the appropriate numbers from 1 to 120 to each of them:
int oddNums = 0;
int evenNums = 0;
for (int i = 1; i < 121; i++)
{
    if ((i % 2) == 0)
    {
        evenNums = evenNums + i;
    }
    else
    {
        oddNums = oddNums + i;
    }
}
Console.WriteLine("");
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenNums}'dır.");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddNums}'dır.");