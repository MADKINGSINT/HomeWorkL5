int[] array = new int[10];
void CreateRandomArray(int[] array)
{
     int length = array.Length;
     int index = 0;
     while (index < length)
     {
      array[index ] = new Random().Next(100,1000);
      index++;
     }
     }
CreateRandomArray(array);
void PrintArray(int[] array)
{
 foreach (var item in array) {
            Console.Write($"{item}, ");
            
            }
}
PrintArray(array);
System.Console.WriteLine(" ");
void FindDel2Numbers (int[]array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)   
{
    if (array[i] % 2 ==0)
    {
        count++;
    }
}   
System.Console.WriteLine($"в массисе {count} четных чисел ");     
}
FindDel2Numbers(array);
Console.WriteLine(" ");