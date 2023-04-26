// * Classroom tasks

// Console.WriteLine("Введите первое число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a == b*b) {
// Console.WriteLine("Yes");
// } else {
// Console.WriteLine("No");
// }

// * HOMEWORK 1. TASK 1.

// Console.WriteLine("Введите первое число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a > b) {
// Console.WriteLine("a - большее число и составляет: " + a + " а меньшее это: " + b);
// } else { 
// Console.WriteLine("b - большее число и составляет: " + b + " а меньшее это: " + a); 
// } 

// * HOMEWORK 1. TASK 2.

// int max = 0;
// Console.WriteLine("Введите первое число: ");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int thirdNumber = int.Parse(Console.ReadLine());
// if(firstNumber > max) {
//     max = firstNumber;
// }
// if(secondNumber > max) {
//     max = secondNumber;
// }
// if(thirdNumber > max) {
//     max = thirdNumber;
// }
// Console.WriteLine("Максимальным из введенных чисел является: " + max);

// * HOMEWORK 1. TASK 3.

// Console.WriteLine ("Введите число которое проверяем на четность: ");
// int a = int.Parse(Console.ReadLine());
// int x = a % 2;
// if(x == 0) {
//     Console.WriteLine("Да");
// } else {
//     Console.WriteLine("Нет");
// }

// * HOMEWORK 1. TASK 4.


Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int s = 2;
if(n > 1) {
    while(s <= n) {
       Console.Write(s + ", ");
        s = s + 2;
    }
}