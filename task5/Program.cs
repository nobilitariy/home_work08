int [] GetArrayDiap(){
    int [] array = new int [2];
    Random rand = new Random();
    array[0] = rand.Next(2, 6);
    array[1] = rand.Next(2, 6);
    return array;
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

int [,] Spiral(int [] array){
    int [,] mass = new int [array[0], array[1]];
    int value = 0;
    int lin = 0;
    int linFin = array[0]-1;
    int col = 0;
    int colFin = array[1]-1;
    while(value < (array[0]*array[1])){
        for(int i = col; i <= colFin; i++){
            mass[lin, i] = value;
            value++;
        }
        lin++;
        for(int i = lin; i <= linFin; i++){
            mass[i, colFin] = value;
            value++;
        }
        colFin--;
        for(int i = colFin; i >= col; i--){
            mass[linFin, i] = value;
            value++;
        }
        linFin--;
        for(int i = linFin; i >= lin; i-- ){
            mass[i, col] = value;
            value++;
        }
        col++;
    }
    return mass;
}

int [] diap = GetArrayDiap();
int [,] mass = Spiral(diap);
PrintArray(mass);