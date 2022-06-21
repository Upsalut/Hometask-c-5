// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

void CoordinatesInArray(int[,] position)
{ 
    int count = position.GetLength(0);
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите координату x[{i}]: ");
         position[i,0] = int.Parse(Console.ReadLine() ?? "0");
         Console.Write($"Введите координату y[{i}]: ");
         position[i,1] = int.Parse(Console.ReadLine() ?? "0");
    }
}
void PrintArray(int[,] array, int k)
{
    int length = array.GetLength(0);
    for (int i = 0; i < length; i++)
    {
       Console.Write($"({array[i,0] * k};{array[i,1] * k}) " );
    }
    Console.WriteLine();
}
Console.Write("Введите кол-во вершин фигуры: ");
int count = int.Parse(Console.ReadLine() ?? "0");
int[,] coordinates = new int[count,2];
CoordinatesInArray(coordinates);
int k = 1;
Console.WriteLine("Координаты вершин фигуры до масштабирования:");
PrintArray(coordinates, k);
Console.WriteLine("Введите коэффициент k:");
k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Координаты вершин фигуры после масштабирования:");
PrintArray(coordinates, k);