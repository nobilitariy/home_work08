int GetNumber(int number1, int number2){
    if(number1 == 0) return number2+1;
    else if(number2 == 0) return GetNumber(number1-1, 1);
    else return GetNumber(number1-1, GetNumber(number1, number2-1));
}

Console.Write("Введите два неотрицательных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int w = GetNumber(number1, number2);
Console.WriteLine(w);

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
/*Console.Clear(); 

int akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return akkerman(m - 1, 1);
        else return akkerman(m - 1, akkerman(m, n - 1));
    }

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция Аккермана равна {akkerman(m, n)}\n ");
*/