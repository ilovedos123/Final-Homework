//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите слова через точку с запятой: ");
string words = Console.ReadLine();
string[] arr = words.Split(';');

int val = 3; //максимальное количество символов в строке, для попадания в итоговый массив

GetFinalArray(arr, val, GetSize(arr,val));

int GetSize(string [] array, int value) //метод для расчета размера итогового массива
{
int size = 0;              
for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <= value)
    {
    size++;
    }
}
 return size;
}

void GetFinalArray (string [] array, int value, int size) //метод для создания и вывода итогового массива
{
string[] finalArray = new string[size];
int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (arr[j].Length <= value)
    {
        finalArray[count] = array[j];
        count++;
    }
}
Console.WriteLine($"[{string.Join(",",finalArray)}]");
}
