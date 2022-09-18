//Задача 56________________________________________________________________

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
    GetSum(result);
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

void GetSum(int[,] array){
    int sum = int.MaxValue;
    int index =0;
    for (int i = 0; i < array.GetLength(0); i++){
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            temp = temp + array[i,j];
        }
        if(temp<sum){
            sum = temp;
            index = i;
        }
       
    }
     Console.WriteLine($"Строкой с наименьшей суммой элементов ({sum}) является {index}.");
}
