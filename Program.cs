// // int lessonNumber = 5;
// // int totalLessons = 1;

// // while (lessonNumber >= totalLessons) {
// //     Console.WriteLine($"Пара {lessonNumber}");
// //     lessonNumber--;
// // }

// // Console.WriteLine("Пары закончились");

// // int total = 0;
// // Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// // int grade = int.Parse(Console.ReadLine());
// // while (grade != -1){
// //     Console.WriteLine($"Оценка принята: {grade}");
// //     total++;
// //     grade = int.Parse(Console.ReadLine());
// // }

// // Console.WriteLine("Ввод завершён");
// // Console.WriteLine($"Кол-во оценок: {total}");

// int sum = 0;
// int count = 0;


// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {

//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

int total = 0;
string correctPassword = "qwerty123";

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");

        break;
    }
    total++;
    Console.WriteLine("Неверный пароль,попробуйте снова");
}
Console.WriteLine($"Кол-во неудачных попыток: {total}");