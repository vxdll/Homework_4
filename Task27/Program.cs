//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
int indexMax = str.Length;
int result = 0;
int num = 0;
for(int i = 0; i < indexMax; i++){
   num = number - number % 10;
   result = result + (number - num);
   number = number / 10;
}
Console.WriteLine("Сумма чисел в числе = " + result);
