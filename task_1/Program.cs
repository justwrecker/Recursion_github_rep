int m = 5;
int n = -142;

void PrintNumbers(int m, int n)
{  int i=m;
if(i>0){
    System.Console.Write(i+" ");}
if (i!=n){
    if(n>m)
    {
        PrintNumbers(m+1,n);
    }
     if(n<m)
    {
        PrintNumbers(m-1, n);
    }
}

}
PrintNumbers(m,n);
// i=2
// выводим 2
// если 2!=11
// то 
// если 11>2
// то 
// выводим 