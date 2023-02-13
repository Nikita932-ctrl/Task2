






int MaxNumber (int a,int b,int c)
{
    int max = 0;
    if (a > b & a > c)
    {
        max = a;
        
    }else if (b > c & b > a)
    {
        max = b;

    }else if (c > b & c > a)
    {
        max = c;
    }
    return max;



}

Console.WriteLine(MaxNumber(4, 22, 111));