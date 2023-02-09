
int math, bio, chem;

Console.WriteLine("Enter your math result: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result: ");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result: ");
chem = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chem >= 90) || (math >= 90 && bio >= 90) || (chem >= 90 && bio >= 90))
{
    Console.WriteLine("You're in! Congratulations!");
}
else
{
    Console.WriteLine("Sorry, you're not in!");
};