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

// int a = 15;
// int b = 4;
// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Сумма: {a - b}");
// Console.WriteLine($"Сумма: {a * b}");
// Console.WriteLine($"Сумма: {a / b}");
// Console.WriteLine($"Сумма: {a % b}");
// var result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");
// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));
// Console.WriteLine("Калькулятор");
// Console.Write("Введите перове число: ");
// var num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// var num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Сумма: {num1 - num2}");
// Console.WriteLine($"Сумма: {num1 + num2}");
// if (num2 != 0){
//     Console.WriteLine($"Частное: {num1 / num2}");
// }
// else{
//     Console.WriteLine("Деление на ноль невозможно");
// }
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MinValue);
// int metr1 = 1;
// System.Int32 metr2 = 1;
// Console.WriteLine("Добро пожаловать в анкету!");
// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine();

// Console.Write("Введите вашу фамилию: ");
// string surname = Console.ReadLine();
// Console.Write("Введите вашу группу: ");
// string group = Console.ReadLine();
// Console.Write("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine());

// Console.Write("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine());
// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;

// string status = isExcellent ? "Отличник" : "Хорошист";

// Console.WriteLine("Ваша анкета");
// Console.WriteLine($"Имя:         {name} {surname}");
// Console.WriteLine($"Группа:      {group}");
// Console.WriteLine($"Возраст:     {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Статус:      {status}");
// Console.WriteLine($"Лет до 30:   {30 - age}");

// Console.WriteLine("Нажмите Enter для выхода...");
// Console.ReadLine();

// Задание 1
string anime = "Attack on Titan";
int number = 7;
double pi = Math.PI;
char letter = 'Щ';
Console.WriteLine($"Любимое аниме/фильм: {anime}");
Console.WriteLine($"Любимая цифра: {number}");
Console.WriteLine($"Число пи: {pi}");
Console.WriteLine($"Любимая буква: {letter}");

// Задание 2
Console.WriteLine("I");
Console.WriteLine("need");
Console.WriteLine("more");
Console.WriteLine("power!");

// Задание 3
Console.WriteLine("\"Hello There\"");

// Задание 4
Console.Write("Стоимость монитора: ");
int monitor = int.Parse(Console.ReadLine());
Console.Write("Стоимость системного блока: ");
int casePc = int.Parse(Console.ReadLine());
Console.Write("Стоимость клавиатуры: ");
int keyboard = int.Parse(Console.ReadLine());
Console.Write("Стоимость мыши: ");
int mouse = int.Parse(Console.ReadLine());
int pc = monitor + casePc + keyboard + mouse;
int pc3 = pc * 3;
Console.WriteLine($"Стоимость покупки трех компьютеров: {pc3}");

Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
double result = 3 * Math.Pow(a + b, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41;
Console.WriteLine($"Значение функции f(x) = {result}");

Console.Write("Введите температуру в °C: ");
double c = double.Parse(Console.ReadLine());
double f = (c * 9 / 5) + 32;
Console.WriteLine($"Температура: {f}°F");