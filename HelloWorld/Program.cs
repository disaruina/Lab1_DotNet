// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Максим";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// var city = "Москва";
// var year = 2026;
// var pi = 3.14159;
// var isActive = true;

// string myName = "Максим";
// int myAge = 20;
// string myGroup = ""ИСП-242;

// Console.Writeline($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// Console.Write("Введите ваше имя: ");
// string name2 = Console.Readline();
// Console.WriteLine($"Привет, {name2}!");

// Console.Write("Введите ваш возраст: ");
// string input = Console.Readline();
// int age2 = int.Parse(input);
// Console.WriteLine($"через 10 лет вам будет {age2 + 10} лет.");

// int x = 10;
// int y = 3;
// Console.WriteLine(x + y);
// Console.WriteLine(x - y);
// Console.WriteLine(x * y);
// Console.WriteLine(x / y);
// Console.WriteLine(x % y);

// var firstName = "Максим";
// var lastName = "Максимов";
// var group = "ИСП-242";
// var birthYear = 2008;
// var gpa = 4.5;
// var hasScholarship = true;

// var currentYear = 2026;
// var age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age}");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично! {firstName} любит {subject}");

int a = 15;
int b = 4;
Console.WriteLine($"Сумма: {a + b}");
Console.WriteLine($"Сумма: {a - b}");
Console.WriteLine($"Сумма: {a * b}");
Console.WriteLine($"Сумма: {a / b}");
Console.WriteLine($"Сумма: {a % b}");
var result = (double)a / b;
Console.WriteLine($"Частное (double): {result}");
Console.WriteLine(Math.Abs(-5));
Console.WriteLine(Math.Pow(2, 10));
Console.WriteLine(Math.Sqrt(144));
Console.WriteLine(Math.Max(10, 25));
Console.WriteLine(Math.Min(10, 25));
Console.WriteLine(Math.Round(3.567, 2));
Console.WriteLine("Калькулятор");
Console.Write("Введите перове число: ");
var num1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
var num2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Сумма: {num1 - num2}");
Console.WriteLine($"Сумма: {num1 + num2}");
if (num2 != 0){
    Console.WriteLine($"Частное: {num1 / num2}");
}
else{
    Console.WriteLine("Деление на ноль невозможно");
}
