int [] GetArrayDiap(){
    int [] array = new int [2];
    Random rand = new Random();
    array[0] = rand.Next(2, 6);
    array[1] = rand.Next(2, 6);
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
