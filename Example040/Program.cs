// 40. Задать массив из 8 целых элементов и вывести их на экран
System.Console.Write("Введите длину массива: ");

int length = Int32.Parse(System.Console.ReadLine());

void CreateArray(int x)
{
    int[] array = new int[x];
    System.Console.WriteLine("Вводите элементы массива"); 
    for(int i = 0; i < x; i++)
    {
        array[i] = Int32.Parse(System.Console.ReadLine());
        
    }
    System.Console.Write("Массив: ");
    for(int i = 0; i < x; i++)
    {
        System.Console.Write($"{array[i]} ");
    }

}

CreateArray(length);


