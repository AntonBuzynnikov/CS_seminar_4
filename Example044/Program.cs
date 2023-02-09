//
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
//Линейный поиск
int find = 5;
int j = 0;
while (j<array.Length && array[j]!= find) j++;
if (j == array.Length)
    System.Console.WriteLine("NO");
else
    System.Console.WriteLine($"Элемент {find} находится под индексом {j}");

