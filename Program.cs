// 1ый метод (математический)
/*
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int result = (number/100)*10+number%10;
Console.WriteLine (result);
*/
// 2ой метод (строковый)
/*
Console.WriteLine("Enter three-digit number: ");
string Numbers = (Console.ReadLine()!);

if(Numbers.Length !=3)
{
    Console.WriteLine("Entered wrong number!");
}
else
{
    Console.WriteLine($"Number without second digit is: {Numbers[0]}{Numbers[2]}");
}
*/
//Домашняя работа по второму семинару
// Задача 10
/*
Console.WriteLine("Enter three-digit number: ");
String Numbers = (Console.ReadLine()!);

if (Numbers.Length !=3)
{
    Console.WriteLine("Entered wrong number!");
}
else
{
    Console.WriteLine($"Number without first and third digit is: {Numbers[1]}");
}
*/
// Задача 13
/*
int number = new Random().Next(1,100000);
int s = (number % 1000)/100;
Console.WriteLine(number);
if (s > 0)
{
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("The third digit is absent");
}
*/
//Задача 15
/*
Console.WriteLine("Enter a number");
int P = int.Parse(Console.ReadLine()!);
 String Numbers = Convert.ToString((P<=7));


if (P==1) Console.Write("Monday");
if (P==2) Console.Write("Tuesday");
if (P==3) Console.Write("Wednesday");
if (P==4) Console.Write("Thursday");
if (P==5) Console.Write("Friday");
if (P==6) Console.Write("Saturday");
if (P==7) Console.Write("Sunday");
if (P==8) Console.WriteLine("error");
*/