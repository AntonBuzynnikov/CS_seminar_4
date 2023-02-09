// 49.
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

int max = array[0];
int min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
System.Console.WriteLine($"Max = {max}, Min = {min}");
System.Console.WriteLine($"Разница элементов {max - min}");