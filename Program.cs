// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.//

//Console.Write("Введите первое число: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int b = Convert.ToInt32(Console.ReadLine());

//if(a<b){
//    Console.WriteLine("первое число меньше, второе больше");
//}
//else{
//    Console.WriteLine("первое число больше, второе меньше");
//}


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) 
{
    b = max;
}
if (c > max)
{
    c = max;
}
Console.WriteLine( max );






 