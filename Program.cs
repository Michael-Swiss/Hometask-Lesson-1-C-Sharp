// Console.WriteLine("Введите первое число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число b: ");
// int b = int.Parse(Console.ReadLine());

// if (a == b*b) {
// Console.WriteLine("Yes");
// } else {
// Console.WriteLine("No");
// } 

// Console.WriteLine("Введите первое число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число b: ");
// int b = int.Parse(Console.ReadLine());

// if (a > b) {
// Console.WriteLine("a - большее число и составляет: " + a + " а меньшее это: " + b);
// } else { 
// Console.WriteLine("b - большее число и составляет: " + b + " а меньшее это: " + a); 
// } 

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



Console.WriteLine ("Введите число которое проверяем на четность: ");
int a = int.Parse(Console.ReadLine());
int x = a % 2;
if(x == 0) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}