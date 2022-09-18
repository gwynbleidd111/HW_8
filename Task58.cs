//Задача 58________________________________________________________________

Console.Write("Введите количество строк 1-го и 2-го масива: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов 1-го и 2-го масива: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);

if(m>0 && n>0){
    int[,] result1 = CreateRandomArray(m, n);
    Console.WriteLine("");
    Console.WriteLine("Массив 1: ");
    Print2DArray(result1);

    int[,] result2 = CreateRandomArray(m, n);
    Console.WriteLine("");
    Console.WriteLine("Массив 2: ");
    Print2DArray(result2);
    
    int [,] product = new int[m, n];
    Console.WriteLine("");
    Console.WriteLine("Произведение: ");
    GetProduct(result1, result2, product);
    Print2DArray(product);


}

else{
    Console.WriteLine("Введите число больше нуля.");
}

if (!isM || !isN){
    Console.WriteLine("Введите число.");
    return;
}

int[,] CreateRandomArray(int m, int n){
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}

void Print2DArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void GetProduct(int[,] result1, int[,] result2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < result1.GetLength(1); k++)
      {
        sum += result1[i,k] * result2[k,j];
      }
      result[i,j] = sum;
    }
  }
}
