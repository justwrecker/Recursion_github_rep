int m = 111;
int n = 142;

void PrintNumbers(int m, int n)
{  
if(m>0){
    System.Console.Write(m+" ");}
if (m!=n){
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
