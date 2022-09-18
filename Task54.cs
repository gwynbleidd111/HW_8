//Задача 54________________________________________________________________

Console.Write("Введите количество строк: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);


if(m>0 && n>0){
    int[,] result = CreateRandomArray(m, n);
    Console.WriteLine("");
    Console.WriteLine("Массив: ");
    Print2DArray(result);
    Console.WriteLine("");
    Console.WriteLine("Массив, упорядоченный по убыванию элементов каждой строки: ");
    GetArrayDescending(result);
    Print2DArray(result);
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
            array[i,j] = random.Next(0,10);
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

void GetArrayDescending(int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      for (int z = 0; z < array.GetLength(1) - 1; z++){
        if (array[i, z] < array[i, z + 1]){
          int temporary = array[i, z + 1];
          array[i, z + 1] = array[i, z];
          array[i, z] = temporary;
        }
      }
    }
  }
}
