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

int[,] MatrixMultip(int [,] array, int [,] array2){
    int [,] arrayMultip = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
         for (int j = 0; j < array2.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(1); k++){
             arrayMultip[i, j] += array[i, k]*array2[k, j];
            }
        }
    }
    return arrayMultip;
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

int [] diap = GetArrayDiap();
int [,] array = GetArray(diap);
int [,] array2 =  GetArray(diap);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
if(array.GetLength(1) != array2.GetLength(0))
    Console.WriteLine("Матрицы перемножить нельзя");
else{
    int[,] result = MatrixMultip(array, array2); 
    PrintArray(result);
}