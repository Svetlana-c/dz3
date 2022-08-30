Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string FiveDigitNumber = Convert.ToString(number);
if (FiveDigitNumber[0] == FiveDigitNumber[4] || FiveDigitNumber[1] == FiveDigitNumber[3])
{
    Console.Write ("Данное число является палиндромом.");
}
else
{
    Console.Write ("Данное число не является палиндромом.");
}
