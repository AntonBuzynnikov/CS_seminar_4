// 42. Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива
System.Console.Write("Введите длину массива: ");

int length = Int32.Parse(System.Console.ReadLine());

void CreateArray(int x)
{
    int[] array = new int[x];
    Random N = new Random();
    for(int i = 0; i < x; i++)
    {
        array[i] = N.Next(-9,10);
    }
    System.Console.Write("Массив: ");
    for(int i = 0; i < x; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    int sumPositive = 0;
    int sumNegative = 0;   
    for(int i = 0; i < x; i++)
    {
        if(array[i] > 0) sumPositive+=array[i];
        if(array[i] < 0) sumNegative+=array[i];
    }
    System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
    System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");
}

CreateArray(length);
