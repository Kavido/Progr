Console.WriteLine("Введите цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

   void CheckingTheDayOfTheWeek (int a)
   { 
     if (a == 6 || a == 7){
         Console.WriteLine(" -> да");
     }
       else if ( a < 1 || a > 7){
             Console.WriteLine("Это не день недели >:[");
       }
        else Console.WriteLine(" -> нет");
 }
 CheckingTheDayOfTheWeek (a);