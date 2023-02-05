// 41. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
System.Console.Write("Введите длину массива: ");

int length = Int32.Parse(System.Console.ReadLine());

void CreateArray(int x)
{
    int[] array = new int[x];
    Random N = new Random();
    for(int i = 0; i < x; i++)
    {
        array[i] = N.Next(2);
    }
    System.Console.Write("Массив: ");
    for(int i = 0; i < x; i++)
    {
        System.Console.Write($"{array[i]} ");
    }

}

CreateArray(length);