Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int SumOfNaturals(int m, int n, ref int sum)
{
   
   for (int i = m; i <= n; i++)
   {
   sum += i;
   }
   return sum;
   
}
SumOfNaturals(m, n, ref sum);
Console.WriteLine(sum);
