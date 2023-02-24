Console.Write("Введите N: ");
string N = Console.ReadLine();
int[] array = new int[5];
if (N.Length == 5)
{
if (N[0] == N[4] || N[1] == N[3])
{
    Console.Write("Число является палиндромом");
    } 
else 
{
    Console.Write("Число не является палиндромом");
    }}

else
{
    Console.Write("Введите пятизначное число");
}
