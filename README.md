# Fibonacci-Binary-converter

A simple program in Console app .net framework C#

Base description:

- first the program writes all Fibonacci numbers up to 4,000,000 and during that time it writes all these numbers in the List named firstAnswer
```C#
 int a = 0, b = 1, c, i;
Console.WriteLine(a);
Console.WriteLine(b);
List<int> firstAnswer = new List<int> { 0, 1 };

for (i = 2; i <= 33; i++)
{
    c = a + b;
    Console.ReadKey();
    Console.WriteLine(c);
    firstAnswer.Add(c);
    a = b;
    b = c;
}
```
- then all even numbers that were in the previous "firstAnswer" List are added to the sum1 List. After that sum of all even numbers is displayed.
```C#
List<int> sum1 = new List<int>();
foreach (var d in firstAnswer)
{
    if (d % 2 == 0)
    {
        sum1.Add(d);
    }
}
int sum = 0;
foreach (var item in sum1)
{
    Console.ReadKey();
    sum += item;
    Console.WriteLine(item);
}  

Console.WriteLine(sum);
```
- Finally, the program asks the user for a binary number, which is then converted to a decimal system
```C#
Console.Write("\nEnter the number in binary to traansfer it to decimal number: ");
int binaryInput = int.Parse(Console.ReadLine());
int decimalNumber = 0;
int g = 1;
while (binaryInput > 0)
{
    int h = binaryInput % 10;
    binaryInput = binaryInput / 10;
    decimalNumber += h * g;
    g = g * 2;
}
Console.WriteLine("Entered number in decimal system: " + decimalNumber);
```
<br></br>
<h3>If there are any problems write to my discord:</h3><a href="https://discordapp.com/users/869579499266793512" target="_blank" title="My discord account" id="logo" target="_blank" data-hveid="8"><img src="https://jablickar.cz/wp-content/uploads/2021/03/Discord-logo.png.webp" height="50" width="80"></a>


