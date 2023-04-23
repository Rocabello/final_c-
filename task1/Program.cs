


// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
System.Console.WriteLine("Введите кол-во строк в исходном массиве: ");
int StartArray = int.Parse(Console.ReadLine());

string[] Strings = new string[StartArray];
for (int i =0; i< StartArray; i++){
    System.Console.WriteLine($"Строка №{i+1}: ");
    Strings[i] = System.Console.ReadLine();
}



//--------------Метоод----------

string[] DoArray (string[] array){
    string[] Array = new string[array.Length];
    int count = 0;
    foreach (string el in array){
        if (el.Length <=3){
            Array[count] = el;
            count++;
        }
    }
}