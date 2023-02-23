int cube = 5;
void Cube(int[] cube)
{
    int count = 0;
    int length = cube.Length;
    while (count < length)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube + 1];
Cube(arry);
PrintArray(arry);