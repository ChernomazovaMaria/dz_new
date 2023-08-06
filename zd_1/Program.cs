// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами, округленными до одного знака
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[m,n];
for (int i = 0; i< m; i++) {
    for (int j = 0; j < n; j++) {
        a[i,j] = Math.Round(Convert.ToDouble(Console.ReadLine()),1);
    }
}
Console.WriteLine("Получившийся массив");
for(int i=0; i<m;i++) {
    for (int j = 0;j<n; j++) {
        Console.Write("{0}\t",a[i,j]);
    }
    Console.WriteLine();
}