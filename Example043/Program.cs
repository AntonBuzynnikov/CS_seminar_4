// 43. Написать подпрограмму замены элементов целочисленного массива типа int
//     на противоположные по значению. Подпрограмма принимает на вход массив и в нём же и меняет значения.
System.Console.WriteLine("Введите длину массива: ");
int length = Int32.Parse(System.Console.ReadLine());
int[] array = new int[length];
System.Console.Write("Массив: ");
for(int i = 0; i < length;i++)
{
    Random rand = new Random();
    array[i] = rand.Next(1,11);
    System.Console.Write($"{array[i]} ");
}
void Array(int[] arr)
{
    System.Console.Write("Новый массив: ");
    for(int i = 0; i < arr.Length;i++)
    {
        arr[i] = -1*arr[i];
        System.Console.Write($"{arr[i]} ");
    }
}

System.Console.WriteLine();
Array(array);