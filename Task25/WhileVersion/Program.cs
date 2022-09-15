//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = A;
while ( count < B){
    result = A * result;
    count = count + 1;
}
Console.WriteLine("A в степени B = " + result);

