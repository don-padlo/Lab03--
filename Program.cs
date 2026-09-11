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
Console.WriteLine($"LessoNumber++ выводит: {lessonNumber++}");
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

bool CheckAndPrint(string label,bool value) {
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
