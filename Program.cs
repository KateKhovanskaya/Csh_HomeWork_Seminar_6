// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
Console.WriteLine("Введите любые целые числа через пробел");
string[] numS = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Положительных чисел {NumPositive(numS)}");
//----Методы------
int NumPositive(string[] arrStr){
    int quontPositive=0;
    foreach(string str in arrStr){
        if(Convert.ToInt32(str)>0){
            quontPositive+=1;
        }
    }
    return quontPositive;
}