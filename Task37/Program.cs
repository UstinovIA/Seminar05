// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)//Задаем массив
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)//Выводим массив на экран
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] CompArray(int[] arr)//Функция вычисления произведений
{
    int size = arr.Length;
    int sizeNewArray = size % 2 == 0 ? size / 2: size / 2 + 1;
    int[] temp = new int[sizeNewArray];
    for (int i = 0; i < sizeNewArray; i++)
    {
        temp[i] = arr[i] * arr[size - i - 1];  //ЗАполняю массив для вывода
    }
    if (size % 2 != 0) temp[sizeNewArray - 1] = arr[size / 2]; //Вводим в конец число, если размер массива нечетный
    return temp;
}

int[] array = CreateArrayRndInt(5, 0, 9);
PrintArray(array);
int[] result = CompArray(array);
PrintArray(result);