// Написать программу копирования массива
void PrintArray(int[] array)
{
    foreach(int digit in array)
        Console.Write($"{digit} ");
}
int[] array = new int[10];
int length = array.Length;
int[] arrayCopy = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
    array[i] = random.Next(-100,100);

Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();

for (int j = 0; j < length; j++)
   arrayCopy[j] = array[j]; 

Console.WriteLine();
Console.WriteLine("Скопированный массив:");
PrintArray(arrayCopy);
