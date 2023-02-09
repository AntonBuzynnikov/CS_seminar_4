// 48. Задан массив а из N элементов. Заполнить массив случайными числами от 1 до 10.
//     Создайте массив, который является произведением пар чисел в одномерном массиве а.
//     Парой считаем первый и последний элемент, второй и предпоследний и так далее.

System.Console.Write("Введите длину массива: ");
int N = Int32.Parse(System.Console.ReadLine());
int[] a = new int[N];
System.Console.Write("Массив: ");
for(int i = 0; i < a.Length;i++)
{
    Random rand = new Random();
    a[i] = rand.Next(1,11);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();

int[] b = new int [N/2];
System.Console.Write("Новый массив:");
for(int i = 0; i< N/2;i++)
{
    b[i] = a[i]*a[N-1-i];
    System.Console.Write($"{b[i]} ");
}