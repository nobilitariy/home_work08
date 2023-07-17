Console.Write("Введите натуральное числo:");
int number = Convert.ToInt32(Console.ReadLine());

void Number(int number){
    Console.Write($"{number} ");
    if(number > 1) Number(number-1);      
}
Number(number);
Console.WriteLine();