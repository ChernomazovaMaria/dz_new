// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
int [,] a = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
Console.WriteLine("Введите первый индекс");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй индекс");
int j = Convert.ToInt32(Console.ReadLine());
if (i < a.GetLength(0) && j < a.GetLength(1)) {
    Console.WriteLine("Элемент под индексом {0},{1} равен = {2}", i, j, a[i,j]);
} else {
    Console.WriteLine("Элемента не существует");
}
