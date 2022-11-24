void ShowArray(int[] array)
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