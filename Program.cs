// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// Console.WriteLine("Введите любые целые числа через пробел");
// string[] numS = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"Положительных чисел {NumPositive(numS)}");
// //----Методы------
// int NumPositive(string[] arrStr){
//     int quontPositive=0;
//     foreach(string str in arrStr){
//         if(Convert.ToInt32(str)>0){
//             quontPositive+=1;
//         }
//     }
//     return quontPositive;
// }

//Задача 43: Написать программу, которая на вход принимает массив из 
//любого количества элементов (не менее 6)в промежутке от 0 до 100,
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
int[] arr43=RandomArray(10,1,20);
Console.WriteLine($"[{String.Join(",", arr43)}]");
SortArr(arr43);
Console.WriteLine();
Console.WriteLine($"[{String.Join(",", arr43)}]");
//----Методы------
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//сортировка массива
void SortArr(int[] arr){
    int sortSize=arr.Length-1;
    while (sortSize>=1){
        for(int i=0; i<sortSize;i++){
            if(arr[i+1]<arr[i]){
             int temp=arr[i];
                arr[i]=arr[i+1];
                arr[i+1]=temp;
             }
        }
        sortSize--;
    }
}