//Задача 60________________________________________________________________

int n = 2;
int a = 10;
int b = 99;
int[,,] array = GetArray(new int[] {n, n, n}, a, b);
PrintArray(array);

int[,,] GetArray(int[] array, int a, int b){
    int[,,] result = new int[n,n,n];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            for(int k=0; k < result.GetLength(2); k++){
                int element = new Random().Next(a, b+1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
            } 
        }
    }
    return result;
}


bool FindElement(int[,,] array, int element){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                if (array[i, j, k] == element) 
                return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();

        }
    }
}
