int[] GetCube(int n)
{
    int[] arr = new int [n];
    for (int i = 1; i <= n; i++) 
    {
        arr [i - 1] = i * i *i;
    }
    return arr;
}
foreach (int num in GetCube(5)) 
{
    Console.WriteLine(num);
}