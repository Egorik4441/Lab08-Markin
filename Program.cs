// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

int total = 0;
Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1){
    Console.WriteLine($"Оценка принята: {grade}");
    total++;
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");
Console.WriteLine($"Кол-во оценок: {total}");