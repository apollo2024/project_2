Console.WriteLine("number:");
var number = Convert.ToInt64(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("не трехзначное");
}
else
if ( number > 999)
{
    var m = 10;
    var n = number;
    for (int i = 999; n > i;n = n / m);
    var sum = n - (n / 10) * 10;
     Console.WriteLine(sum);
}
else
{
    var sum = number - (number / 10) * 10;
    Console.WriteLine(sum);
}
