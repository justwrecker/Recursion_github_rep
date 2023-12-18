int m = 3;
int n = 5;
int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return  n + 1;

    }
   else if (m > 0 && n == 0)
    {

        return Ackerman(m - 1, 1);
    }
  else  
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }

}
System.Console.WriteLine(Ackerman(m, n));
// подставлять на место m и n значения больше 5 не имеет смысла