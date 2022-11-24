
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] FirstArray() 
{
  Console.Write("Напишите какой длины создаётся массив: ");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
  Console.WriteLine("Создаём массив: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите значение {i + 1} элемента массива: ");
    array[i] = Console.ReadLine();
  }
  Console.WriteLine("Готово!");
  return array;
}

string[] SecondArrayMax3(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

string[] stringArray = FirstArray();
ShowArray(SecondArrayMax3(stringArray));