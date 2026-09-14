Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500; //пополнение
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200; //покупка
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05; //начисление 5% процентов
Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2; //разделили счёт пополам с партнёром
Console.WriteLine($"После деления пополам: {balance}");


Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"LessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После этого LessonNumber: {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");

int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");


Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge} :{isExactAge}");
Console.WriteLine($"Возраст {myAge}>= {votingAge}(может голосовать)");
Console.WriteLine($"Балл {myGrade}!= 2.0 (): {isNotFailing}");


Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value)
{
    Console.WriteLine($" Вычисляем: {label}");
    return value;
}

Console.WriteLine("Проверяем && (первый операнд false)");
bool resultAnd = CheckAndPrint("Al", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true)");
bool result0r = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {result0r}");


Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 2) * 4;
Console.WriteLine($"2 + 3 * 4       = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4         = {resultWithParens}");
bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5>3 && 2<4 || false         = {logicResult}");
Console.WriteLine($"(5>3 && 2<4) || false   = {logicResultParens}");


Console.WriteLine();
Console.WriteLine("Приёмная комиссия");

Console.WriteLine("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.WriteLine("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.WriteLine("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);

// TODO 1: hasGoodCertificate = true, если averageGrade >= 4.0
bool hasGoodCertificate = (averageGrade >= 4.0);

// TODO 2: hasGoodExam = true, если examScore >=60
bool hasGoodExam = (examScore >= 60);

// TODO 3: isEligibleByRules = true, если 
// (hasGoodCertificate И hasGoodExam) или hasBenefit
bool isEligibleByRules = (hasGoodCertificate && hasGoodExam || hasBenefit);

// TODO 4: итоговый балл = средний балл * 10, а затем прибавьте баллы
// экзамена используйте оператор += для второго шага
double totalScore = averageGrade * 10;
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");


Console.WriteLine("Введите число: ");
int integer = int.Parse(Console.ReadLine());
bool boolIsEven = ((integer % 2) == 0);

Console.WriteLine($"Чётность числа - {boolIsEven}");


int x = 1;
int y = 1;

Console.WriteLine();
Console.WriteLine($"Сложение: {1 + x++}");
//сложилось старое число, после чего оно увеличилось на 1
Console.WriteLine(x);

Console.WriteLine();
Console.WriteLine(1 + ++y);
//сразу сложилось увеличенное число
Console.WriteLine(y);

Console.WriteLine();
Console.WriteLine($"Вывод чисел: x = {x++} y = {++y}");
//++x выводит на экран старое число,после чего увеличивает его
Console.WriteLine($"x = {x}");


Console.WriteLine();
Console.WriteLine("Введите сумму покупки: ");
double summa = double.Parse(Console.ReadLine());

Console.WriteLine("У вас есть наша карта?(1 - да, 0 - нет): ");
int Card = int.Parse(Console.ReadLine());
bool card = (Card == 1) || false;

Console.WriteLine("Укажите кол-во товаров: ");
int kol = int.Parse(Console.ReadLine());

bool eligibleForDiscount = (kol >= 3 && summa >= 3000) || card;

Console.WriteLine();
Console.WriteLine($"Кол-во товаров и сумма стоимости - {kol}, {summa}");
Console.WriteLine($"Карта магазина - {card}");
Console.WriteLine($"Доступность скидки - {eligibleForDiscount}");