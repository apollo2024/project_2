Console.WriteLine("put date of the day:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0 || number > 31)
{
    Console.WriteLine("your number is not a day");
}
else
if (number %7 == 0 || number %6 == 0)
{
    Console.WriteLine("this day is a holiday");
}
else 
{
    Console.WriteLine("this day is not a holiday");
}