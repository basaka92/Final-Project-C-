int InputInt32(string message)
{
  Console.WriteLine(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void FillArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine($"Введите {i} элемент массива строк:");
    array[i] = Console.ReadLine();
  }
}

void PrintArray(string[] array, string message)
{
  Console.Write(message);
  foreach (var element in array)
  {
    Console.Write($"[{element}]");
  }
}

string[] NewArray(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3) count++;
  }
  string[] arrayRes = new string[count];
  int index = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      arrayRes[index] = array[i];
      index++;
    }
  }
  return arrayRes;
}

try
{
  int arraySize = InputInt32("Задайте размерность массива (целое положительное число):");
  string[] array = new string[arraySize];
  FillArray(array);
  PrintArray(array, "Изначальный массив: ");
  array = NewArray(array);
  Console.WriteLine();
  if (array.Length != 0)
  PrintArray(array, "Конечный массив: ");
  else
  Console.WriteLine("В данном массиве нет строк, длина которых меньше либо равна 3!");
}
catch
{
  Console.WriteLine();
  Console.WriteLine("Введены некорректные данные!");
}