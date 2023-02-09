// 46. В одномерном массиве из 123 элементов найти количество элементов из отрезка [10,99]

int[] array = new int[123];
System.Console.Write("Массив: ");
for(int i = 0; i < array.Length;i++)
{
    Random rand = new Random();
    array[i] = rand.Next(1,500);
    System.Console.Write($"{array[i]} ");
}

int count = 0;
for (int i = 0;i<array.Length;i++)
{
    if(array[i]>=10 && array[i]<=99)
        count+=1;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов из отрезка [10,99]: {count}");