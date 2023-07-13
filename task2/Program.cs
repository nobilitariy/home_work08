int [] GetArrayDiap(){
    int [] array = new int [2];
    Random rand = new Random();
    array[0] = rand.Next(2, 6);
    array[1] = rand.Next(2, 6);
    while(array[0] == array[1]){
        array[1] = rand.Next(2, 6);
    }
    return array;
}

int GetRand(){
    Random rand = new Random();
    int number = rand.Next(1,11);
    return number;
}

int [,] GetArray(int [] array){
    int [,] arrayNew = new int [array[0], array[1]];
    for(int i = 0; i < array[0]; i++){
        for(int j = 0; j < array[1]; j++){
            arrayNew[i, j] = GetRand();
        }
    }
    return arrayNew;
}

void PrintArray(int [,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [] GetAverage(int [,] array){
    PrintArray(array);
    int [] arrayNew = new int [array.GetLength(0)];
    for(int i = 0; i <  array.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        arrayNew[i] = sum;
    }
    return arrayNew;
}

void MaxAverage(int [] array){
    int maxIndex = 0;
    for(int i = 1; i < array.Length; i++){
        if(array[i] > array[maxIndex]){
            maxIndex = i;
        } 
    }
    Console.WriteLine();
    Console.WriteLine($"Cтрока с наибольшей суммой элементов равна {maxIndex+1}");
}

int [] diap = GetArrayDiap();
int [,] array = GetArray(diap);
int [] arrayNew = GetAverage(array);
MaxAverage(arrayNew);