// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for(int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(0, 100);
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

int GetMaxNum(int[] array)
{
  int max = array[0];
  for(int i = 0; i < array.Length; i++)
  {
    if(max < array[i]) max = array[i];
  }
  return max;
}

int GetMinNum(int[] array)
{
  int min = array[0];
  for(int i = 0; i < array.Length; i++)
  {
    if(min > array[i]) min = array[i];
  }
  return min;
}

Console.WriteLine(GetMaxNum(arr));
Console.WriteLine(GetMinNum(arr));
int result = GetMaxNum(arr) - GetMinNum(arr);
System.Console.WriteLine(result);