//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int[] array = new int[8];
for (int i = 0; i < 8; i++){
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
 
Console.WriteLine("Вывод с помощью for");
Console.Write("[ ");
for (int i = 0; i < array.Length - 1; i++)
{
Console.Write("{0}, ", array[i]);
}
Console.Write(array[array.Length - 1] + " ]");
