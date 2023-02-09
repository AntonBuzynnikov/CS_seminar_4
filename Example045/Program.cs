// 45. Задать массив, заполнить случайными положительными числами.
// показать количество чётных, нечётных
System.Console.Write("Введите длину массива: ");
int length = Int32.Parse(System.Console.ReadLine());
int[] array = new int[length];
System.Console.Write("Массив: ");
for(int i = 0; i < array.Length;i++)
{
    Random rand = new Random();
    array[i] = rand.Next(1,500);
    System.Console.Write($"{array[i]} ");
}

int count1 = 0;
int count2 = 0;
for (int i = 0;i<array.Length;i++)
{
    if(array[i]%2 == 0)
        count1+=1;
    else
        count2+=1;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных = {count1}, количество нечётных = {count2}");