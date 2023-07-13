int [] GetArrayDiap(){
    Random rand = new Random();
    int [] array = new int [2];
    array[0] = rand.Next(2, 6);
    array[1] = rand.Next(2, 6);
    return array;
}

int [] GetArray(int [] array){
    int [] arrayNew = new int [array[0]* array[1]];
    return arrayNew;
}

int GetRand(){
    Random rand = new Random();
    int number = rand.Next(10, 100);
    return number;
}

void PrintArray(int [,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            Console.Write($"({i},{j}) {array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixArray(int [] array, int [] arrayDiap){
    int randNum = GetRand();
    array[0] = randNum; 
    for(int i = 1; i < array.Length; i++){
            for(int k = 0; k < i; k++){
                if(array[k] == randNum){
                    randNum = GetRand();
                    k = -1;
                }
            array[i] =  randNum;   
            }  
    }
    int row = arrayDiap[0];
    int col = arrayDiap[1];
    int [,] matrix = new int [row, col];
    for(int i = 0; i < row; i++){
        for(int j = 0; j < col; j++){
            int index =i * col + j;
            matrix[i, j] = array[index];
        }
    }
    return matrix;
}



int [] diap = GetArrayDiap();
int [] array = GetArray(diap);
int [,] matrix = MatrixArray(array, diap);
PrintArray(matrix);