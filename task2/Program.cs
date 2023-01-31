// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for(int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(-20, 50);
  }
  return result;
}

void PrintArray(int[] arr)
{
  foreach(int item in arr)
  {
    System.Console.Write(item + " ");
  }
  System.Console.WriteLine();
}

int[] arr = GetRandomArray(8);
PrintArray(arr);

int GetSumOddArrNum(int[] array)
{
  int sum = 0;
  for(int i = 1; i < array.Length; i += 2)
  {
    sum += array[i];
  }
  return sum;
}
Console.WriteLine(GetSumOddArrNum(arr));