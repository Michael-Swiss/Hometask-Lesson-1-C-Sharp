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

int max = 0;
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber > max) {
    max = firstNumber;
}
if(secondNumber > max) {
    max = secondNumber;
}
if(thirdNumber > max) {
    max = thirdNumber;
}
Console.WriteLine("max = " + max);