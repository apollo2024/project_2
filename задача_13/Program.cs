Console.WriteLine("number:");
var number = Convert.ToInt32(Console.ReadLine());
int m = 10;
if (number < 100)
{
    Console.WriteLine("число не трехзначное");
}
if ( number > 999)
{
    for (int i = 999; number > i; m = m * 10)
    {
         int super_number = (number / m);
         int sum = (super_number / 10) - (super_number / 100) * 10 ;
         Console.WriteLine(sum);
    }
}
else
{
    int sum = (number / 10) - (number / 100) * 10 ;
    Console.WriteLine(sum);
}