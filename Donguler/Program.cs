// her döngü için ayrı int ddeğerleri tanımladım

for (int i =0; i<10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");

}
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("bir ve 20 arasındaki sayılar :");
for (int j = 1; j < 21; j++)
{
    Console.WriteLine(j);

}
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("bir ve 20 arasındaki çift sayılar :");
for (int a = 1; a < 21; a++)
{

 if (a%2 == 0)
    {
        Console.WriteLine(a);
    }
}
Console.WriteLine("----------------------------------------------------------");
int top = 0;
for (int k = 50; k <= 150; k++)
{
    top=top+k;
    
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı :" +top);
Console.WriteLine("----------------------------------------------------------");
int cifttop = 0;
int tektop = 0;
for (int b = 1; b <= 120; b++)
{
    if (b % 2 == 0)
    {
        cifttop += b;
    }
    else
    {
        tektop += b;
    }

}
Console.WriteLine("çift sayıların toplamı :" + cifttop);
Console.WriteLine("tek sayıların toplamı :" + tektop);