// // Рандомно вывести массив из 10 элементов:
// void Fillarray(int[] collection)// void - если метод ни чего не возвращает, то он называется void методом, в этом случае ни в коем случае мы не должны использовать return
// {
//     int length = collection.Length;// получаем длинну нашего массива
//     int index  = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
    
// }

// int[] array = new int[10];// new int[10] - создай новый массив в котором будет 10 элементов

// Fillarray(array);
// PrintArray(array);


// void Fillarray(int[] collection)// void - если метод ни чего не возвращает, то он называется void методом, в этом случае ни в коем случае мы не должны использовать return
// {
//     int length = collection.Length;// получаем длинну нашего массива
//     int index  = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
    
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = 0;

//     while(index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index; 
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];// new int[10] - создай новый массив в котором будет 10 элементов

// Fillarray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);
// тут мф получаем последнее вхождение, чтобы получить первое вхождение сделаем следущее:
// см. ниже (*)

void Fillarray(int[] collection)// void - если метод ни чего не возвращает, то он называется void методом, в этом случае ни в коем случае мы не должны использовать return
{
    int length = collection.Length;// получаем длинну нашего массива
    int index  = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// - искуственный прием, если такого елемета не будет, то на экран будет выводится -1

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // (*)
        }
        index++;
    }
    return position;
}

int[] array = new int[10];// new int[10] - создай новый массив в котором будет 10 элементов

Fillarray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);