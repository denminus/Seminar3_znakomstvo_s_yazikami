// возведите число а в натуральную степень В используя цикл
/*Console.Write("Введите число А ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень В ");
int B = int.Parse(Console.ReadLine()!);

int power =1;
for (int i=1 ; i<=B; i++)
{
    power*=A;  // A=A*power
}
Console.WriteLine("Число " +A+ " в степени " +B+ " равно " + power);

*/
// определение количества цифр в числе
Console.Write("Введите число А ");
int b = int.Parse(Console.ReadLine()!);
int i=0;

while (b>1)
{
    b=b/10;
    i++;
}

Console.WriteLine("количество цифр " +i);

