Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tableCube = 1;

if (number < 1) Console.WriteLine("Перезапустите программу и введите целое число больше или равное 1");
for (int i = 0; i < number; i++)
{
    Console.Write(Math.Pow(i+i, 3) + "; ");
}