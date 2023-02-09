//temp <= 0 - freezing
//temp > 0 && <= 10 - cold
//temp > 10 && <= 15 - chilly
//temp > 15 && <= 20 - warm
//temp >= 20 && < 30 - hot
//temp >= 30 - Welcome to hell

Console.WriteLine("Please enter current temp: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Welcome to hell!");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly");
}
else if (temp < 10 && temp >= 0)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing");
}