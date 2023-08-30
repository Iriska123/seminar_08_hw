/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);
MinSum(array);


int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSum(int[,] array) {
 int sum = 0;
 int[] arr = new int [array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
           sum += array[i,j];
        }
        arr[i] = sum;
        sum = 0;
    } 
 
 int minSum = arr[0];
 int str = 0;
 for(int i = 0; i < arr.Length; i++){
    if(arr[i] < minSum){
        minSum = arr[i];
        str = i;
    }
 }
    Console.WriteLine(String.Join(",",arr));
    Console.WriteLine($"Строка с минимальной суммой: {str} ");
}