// // // // // int lessonNumber = 5;
// // // // // int totalLessons = 1;

// // // // // while (lessonNumber >= totalLessons) {
// // // // //     Console.WriteLine($"Пара {lessonNumber}");
// // // // //     lessonNumber--;
// // // // // }

// // // // // Console.WriteLine("Пары закончились");

// // // // // int total = 0;
// // // // // Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// // // // // int grade = int.Parse(Console.ReadLine());
// // // // // while (grade != -1){
// // // // //     Console.WriteLine($"Оценка принята: {grade}");
// // // // //     total++;
// // // // //     grade = int.Parse(Console.ReadLine());
// // // // // }

// // // // // Console.WriteLine("Ввод завершён");
// // // // // Console.WriteLine($"Кол-во оценок: {total}");

// // // // int sum = 0;
// // // // int count = 0;


// // // // Console.WriteLine("Вводите оценки, для завершения введите -1:");
// // // // int grade = int.Parse(Console.ReadLine());

// // // // while (grade != -1)
// // // // {

// // // //     sum += grade;
// // // //     count++;
// // // //     grade = int.Parse(Console.ReadLine());
// // // // }

// // // // if (count > 0)
// // // // {
// // // //     Console.WriteLine($"Средний балл: {(double)sum / count}");
// // // // }
// // // // else
// // // // {
// // // //     Console.WriteLine("Оценок не было введено");
// // // // }

// // // int total = 0;
// // // string correctPassword = "qwerty123";

// // // while (true)
// // // {
// // //     Console.Write("Введите пароль от личного кабинета: ");
// // //     string password = Console.ReadLine();

// // //     if (password == correctPassword)
// // //     {
// // //         Console.WriteLine("Доступ разрешён");

// // //         break;
// // //     }
// // //     total++;
// // //     Console.WriteLine("Неверный пароль,попробуйте снова");
// // // }
// // // Console.WriteLine($"Кол-во неудачных попыток: {total}");

// // string answer;

// // do
// // {
// //     Console.Write("Введите дату посещения (например, 01.09):");
// //     string date = Console.ReadLine();
// //     Console.WriteLine($"Запись добавлена: {date}");

// //     Console.Write("Добавить ещё одну запись? (да/нет):");
// //     answer = Console.ReadLine();
// // } while (answer == "да");

// // Console.WriteLine("Дневник сохранён");

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 

// if (string.IsNullOrEmpty(surname)) { 
//     Console.WriteLine("Фамилия не введена. Завершение работы."); 
//     return; 
// } 

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 

// var assigned = Enumerable.Range(1, 10) 
//     .OrderBy(_ => rnd.Next()) 
//     .Take(2) 
//     .OrderBy(x => x) 
//     .ToList(); 

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 


string total;
int count = 0;

while (true)
{
    Console.WriteLine("Введи символ:");
    total = 

}
Console.WriteLine($"Кол-во символов {total}");