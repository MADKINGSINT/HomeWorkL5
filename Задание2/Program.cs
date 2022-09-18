int[] array = new int[11];
void CreateRandomArray(int[] array)
{
     int length = array.Length;
     int index = 0;
     while (index < length)
     {
      array[index ] = new Random().Next(0,10);
      index++;
     }
     }
     void PrintArray(int[] array)
     {
foreach (var item in array) {
            Console.Write($"{item}, ");
            
            }
}

CreateRandomArray(array);
PrintArray(array);
void PrintSumOfNumberIndexDel2(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i % 2 > 0)
       {
        System.Console.Write($"индекс {i}, число {array[i] };  ");
        sum = sum + array[i];
       }
    }
    System.Console.WriteLine($"сумма{sum}");
}
PrintSumOfNumberIndexDel2(array);