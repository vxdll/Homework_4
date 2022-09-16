//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Exp (int A, int B){
    int result = 1;
    for ( int i = 0; i < B; i++){
        result = result * A;
    }
    return result;
}
int res = Exp(3,5);
Console.WriteLine("A в степени B = " + res);
