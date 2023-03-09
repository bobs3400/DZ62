Console.Clear();
Console.WriteLine("Введите размер массива");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] arr = GetArray(m, n);
PrintArray(arr);

int[,] GetArray(int m, int n) 
{
     int[,] result = new int[m, n];
     int count = 1;
     int x = 0;
     while(count <= m * n)
     {
        for (int j = x; j < n - x; j++)
        {
            int i = x;
            result[i, j] = count;
            if(count == m * n){return result;}
            count++;
        }
        for (int i = x + 1; i < m - x; i++)
        {
            int j = n - 1 - x;
            result[i, j] = count;
            if(count == m * n){return result;}
            count++;
        }
        for (int j = n - 2 - x; j >= 0 + x; j--)
        {
            int i = m - 1 - x;
            result[i, j] = count;
            if(count == m * n){return result;}
            count++;
        }
        for (int i = m - 2 - x; i >= x + 1; i--)
        {
            int j = x ;
            result[i, j] = count;
            if(count == m * n){return result;}
            count++;
        }
        x++;
     }
        
     return result;
}
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}