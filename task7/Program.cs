Console.Write("Введите два натуральных числа(первое число больше второго): ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNum(int number1, int number2){
    if(number1 == number2) return number1; { 
    return number1 + SumNum(number1+1, number2);
} 
}

int sum = SumNum(number1, number2);
Console.WriteLine(sum);