
int number = 4456;
string numberAsString = number.ToString();
char[] numbers = numberAsString.ToArray();

int amount0 = 0;
int amount1 = 0;
int amount2 = 0;
int amount3 = 0;
int amount4 = 0;
int amount5 = 0;
int amount6 = 0;
int amount7 = 0;
int amount8 = 0;
int amount9 = 0;

foreach (char digit in numbers)
{
    if (digit == '0')
    {
        amount0++;
    }
    else if (digit == '1')
    {
        amount1++;
    }
    else if (digit == '2')
    {
        amount2++;
    }
    else if (digit == '3')
    {
        amount3++;
    }
    else if (digit == '3')
    {
        amount3++;
    }
    else if (digit == '4')
    {
        amount4++;
    }
    else if (digit == '5')
    {
        amount5++;
    }
    else if (digit == '6')
    {
        amount6++;
    }
    else if (digit == '7')
    {
        amount7++;
    }
    else if (digit == '8')
    {
        amount8++;
    }
    else if (digit == '9')
    {
        amount9++;
    }
}
Console.WriteLine(number);
Console.WriteLine('0' + "=" + amount0);
Console.WriteLine('1' + "=" + amount1);
Console.WriteLine('2' + "=" + amount2);
Console.WriteLine('3' + "=" + amount3);
Console.WriteLine('4' + "=" + amount4);
Console.WriteLine('5' + "=" + amount5);
Console.WriteLine('6' + "=" + amount6);
Console.WriteLine('7' + "=" + amount7);
Console.WriteLine('8' + "=" + amount8);
Console.WriteLine('9' + "=" + amount9);