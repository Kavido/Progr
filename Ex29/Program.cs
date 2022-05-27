Console.Write("Введите размер массива:  ");
int elMass = int.Parse(Console.ReadLine());

int [] array = new int [elMass];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элементы массива: ");
array[i] = int.Parse(Console.ReadLine());
}
 Console.Write("");
 
     Console.Write("[ ");
 
 for (int i = 0; i < array.Length; i++)
 {
     Console.Write($"{array[i]} ");
    
 }
  Console.Write("]");