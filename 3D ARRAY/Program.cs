
Console.Write("Enter The Length of 1st Demention Array: ");
int firstD = int.Parse(Console.ReadLine());
Console.Write("Enter The Length of 2nd Demention Array: ");
int secondD = int.Parse(Console.ReadLine());
Console.Write("Enter The Length of 3rd Demention Array: ");
int thirdD = int.Parse(Console.ReadLine());
int entery;
int[,,] number = new int[firstD, secondD,thirdD];
Console.WriteLine();
for (int j = 0; j < firstD; j++)
{
    for (int i = 0; i < secondD; i++)
    {
        for (int k = 0; k < thirdD; k++)
        {
            Console.WriteLine("{0},{1},{2}", j, i, k);
            Console.Write("Enter The Number: ");
            entery = int.Parse(Console.ReadLine());
            number[j, i,k] = entery;
        }
    }
}

Console.WriteLine();
for (int i = 0; i < firstD; i++)
{
    for (int j = 0; j < secondD; j++)
    {
        for (int k = 0; k < thirdD; k++)
        {
            Console.Write(number[i, j,k] + " ");
        }
        Console.Write("\t");
    }
    Console.WriteLine();
}

//foreach ( int a in number)
//{
//    Console.WriteLine(a);
//}