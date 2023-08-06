// Задайте двумерный массив из целых чисел. Найдите средне арифмитическое элементов в каждом столбце.
int [,] a = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
for (int i = 0; i<a.GetLength(1); i++) {
    int sum = 0;
    for (int j = 0; j<a.GetLength(0); j++) {
        sum= a[j,i]+sum;
    }
    double length = Convert.ToDouble(a.GetLength(0));
    double sr = Math.Round(sum / length, 1);
    Console.WriteLine(sr);
}


