// Упорядочить массив. Упорядочивание данных внутри массива. Алгоритм сортировки методом выбора
// алгоритм мин макса
// метод выбора максимального или минимального значения и т.д.

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//         }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// { 
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         //
//         //
//         int temporary = array[i];
//         array[i] = array[minPosition];// обмен позициями
//         array[minPosition] = temporary;
//     }
// } 

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// ДЗ



void SelectionSort(int[]array)
{
for(int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for(int j = i+1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition])
        {
            minPosition = j;
        }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}
}
