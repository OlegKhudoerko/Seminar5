// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[5];
int size = array.Length;
double minNumber = 100;
double maxNumber = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * 100;// Присваиваем случайные вещественные числа элементам массива
    if (array[i] < minNumber) minNumber = array[i];// Находим наименьшее число в массиве
    if (array[i] > maxNumber) maxNumber = array[i];// Находим наибольшее число в массиве
}

Console.WriteLine($"\n[{string.Join("  ", array)}] -> {maxNumber - minNumber}\n");

