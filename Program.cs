// See https://aka.ms/new-console-template for more information
int i, j, sum;
Console.WriteLine("enter start number");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("enter  end");
int end = int.Parse(Console.ReadLine());
for(i=start;i<=end;i++)
{
    sum = 0;
    for (j = 1; j < i; j++)
    {
        if (i % j == 0) 
        {
            sum += j;
        }
    }
        if (sum == i)
            {
            Console.WriteLine(i);
    }
        
}   




    
