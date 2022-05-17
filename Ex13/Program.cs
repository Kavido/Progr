Console.WriteLine("введите число ->");
 int a = Convert.ToInt32(Console.ReadLine());
 string aText = Convert.ToString(a);
  if ( aText.Length > 2)
  {
      Console.WriteLine("Третья цифра -> " + aText[2]);
  }
   else 
   {
       Console.WriteLine(" -> третьей цифры нет");
    
   }