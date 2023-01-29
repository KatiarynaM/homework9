//Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbersRec(N,1));


//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число N: ");
int N2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int M2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumRec(M2,N2));


//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(RecA(m,n));

// ------Metods------------------------

string PrintNumbersRec(int start, int end){// по убыванию
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbersRec(start - 1, end));
}

int SumNumRec(int m, int n){
      int a = m;
      if (m > n){a = n; n = m;}
      if (n == a) return n;
      return n + SumNumRec(a, n - 1);
}

int RecA(int m, int n){
      if (m == 0) return n + 1;
      if ((m != 0) && (n == 0))  return RecA(m - 1, 1);
      return RecA(m- 1, RecA(m, n - 1));

}
