// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int PromptInt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string PromptStr(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    return value;
}

//Задаем массив:
string [] InputArray(int Lenght){
    string[] array = new string [Lenght];
    for(int i=0; i<array.Length; i++){
        array[i] = PromptStr($"Введите {i+1}-й элемент:");
    }
    return array;
}

// Увeличение размера массива и заполняем
string[] AddLastInsert(string[] arr, string text, int k){
    string[] newArray = new string[k];
    newArray[k-1] = text;
    arr = newArray;
    return arr;
}

//Сортировка по заданным условиям
string[] SortArray(string[] arrayOld){
    int m = 3;
    int k = 0;
    string[] arr = new string [k];

    for(int i = 0; i < arrayOld.Length; i++){
        int sizeText = arrayOld[i].Length;
        if(sizeText <= m){
            k++;
            Array.Resize(ref arr, k);
            arr[k-1] = arrayOld[i];
        }
    }
    return arr;
}

// Вывод массива
void PrintArray(string[]array){
    Console.Write("[");
    if(array.Length > 0){
        for(int i = 0; i < array.Length-1; i++){
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length-1]}");
    }
    Console.WriteLine("]");
}

int Lenght = PromptInt("Введите длину исходного массива:");
Console.WriteLine();
string[] arrayOld = InputArray(Lenght);
PrintArray(arrayOld);

Console.WriteLine();
string[] arrayNew = SortArray(arrayOld);
PrintArray(arrayNew);
