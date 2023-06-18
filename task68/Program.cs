int accerman(int m, int n)
{
   if (m ==0)
   {
      return n + 1;
   }
   else if (m > 0 && n == 0)
   {
      return accerman(m-1, 1);
   }
   else if (m > 0 && n > 0)
   {
      return accerman(m-1, accerman(m, n-1));
   }
   else
   {
      return -1;
   }
}
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(accerman(m,n));

