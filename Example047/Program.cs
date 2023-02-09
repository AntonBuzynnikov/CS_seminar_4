// 47
int length = Int32.Parse(Console.ReadLine());
int[] array = new int[length];
//System.Console.WriteLine("Вводите элементы массива"); 
for(int i = 0; i < array.Length; i++)
{
    Random N = new Random();
    array[i] = N.Next(-10,10);    
}
System.Console.Write("Массив: ");
for(int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();
int sum = 0;
for(int i = 0; i<array.Length; i+=2)
    {
        sum+=array[i];
    }
System.Console.WriteLine($"Сумма элементов {sum}");