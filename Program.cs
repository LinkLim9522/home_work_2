int Prompt(string msg)
{
System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите день недели");
string dn = "Это не день недели";
string check(int number)
{
if (number >= 6 && number <= 7) dn = "Это выходной";
if (number >= 1 && number <= 5) dn = "Это будний день";
return dn;
}
System.Console.WriteLine(check(number));