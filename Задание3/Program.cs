int[] array = new int[8];
void CreateRandomArray(int[] array)
{
     int length = array.Length;
     int index = 0;
     while (index < length)
     {
      array[index ] = new Random().Next(1, 100);
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
int maxNumber = 0;
int minNumber = 0;
    void FindMinNumberInArray()
{
     int min = Int32.MaxValue;
    for(var j =0; j < array.Length;j++)
    {
     if (min>array[j])
     {
          min = array[j];
     }
    }
    
System.Console.WriteLine($"минимальное число:  {min}");
minNumber = min;
     
          
} 
    
    

     
     
    
   
   



void  FindMaxNumberInArray()
{
     int  max = Int32.MinValue;
    for(var i =0; i < array.Length;i++)
    {
     if (array[i] > max)
     {
          max = array[i];
     }
    }
System.Console.WriteLine($"максимальное число: {max}");
maxNumber = max; 
          
}
          
     
     
PrintArray(array);
System.Console.WriteLine("  ");
FindMaxNumberInArray();
FindMinNumberInArray();

void FindRaznitsa ()
{
     int sum = maxNumber - minNumber;
     System.Console.WriteLine($"разница между макссимальным и минимальным равна: {sum}");
}
FindRaznitsa();