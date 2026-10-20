// //Шаг 1. Создание и заполнение массива
// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sum = 0;

// for (int i = 0; i < grades.Length; i++) {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
//     sum += grades[i];
// }

// Console.WriteLine("\nВведенные оценки:");
// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }

// Console.WriteLine($"Средний балл группы: {(double)sum / grades.Length}");
// //Шаг 2. Изменение элементов массива
// int[] points = { 4, 7, 2, 9, 5 };
// for (int i = 0; i < points.Length; i++) {
//     if (points[i] < 10) {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points) {
//     Console.WriteLine(point);
// }

// //Шаг 3. Сортировка массива
int[] grades = { 4, 5, 3, 5, 4, 2 };
for (int i = 0; i < grades.Length - 1; i++) {
    for (int j = 0; j < grades.Length - 1 - i; j++) {
        if (grades[j] < grades[j + 1]) { 
            int temp = grades[j];
            grades[j] = grades[j + 1];
            grades[j + 1] = temp;
        }
    }
}

foreach (int grade in grades) {
    Console.WriteLine(grade);
}
//Шаг 4. Метод, возвращающий массив
int[] GenerateScheduleSlots(int lessonsCount) {
    int[] slots = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++) {
        slots[i] = i + 1;
    }
    return slots;
}

int[] GenerateEvenSlots(int lessonsCount) {
    int[] evenSlots = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++) {
        evenSlots[i] = (i + 1) * 2;
    }
    return evenSlots;
}

int[] slots = GenerateEvenSlots(6);
foreach (int slot in slots) {
    Console.WriteLine(slot);
}
// //Шаг 5. Знакомство с Array.Sort()
// int [] grades = {4,5,3,5,4,2};
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// //Самостоятельные задания ★
// //Задача А
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// int[] squares = new int[n];

// for (int i = 0; i < n; i++) {
//     squares[i] = (i + 1) * (i + 1);
// }

// Console.WriteLine("Массив квадратов:");
// foreach (int num in squares) {
//     Console.WriteLine(num);
// }

// //Задача Б
// int[] numbers = { -3, 5, -1, 8, -7, 0, 2 };
// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] < 0) {
//         numbers[i] = 0;
//     }
// }

// Console.WriteLine("Результат:");
// foreach (int num in numbers) {
//     Console.WriteLine(num);
// }

//Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_
// => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
//Вариант 7
int[] SquareAll(int[] numbers) {
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++) {  
        result[i] = numbers[i] * numbers[i];
    }
    return result;
}

int[] original = { 1, 2, 3, 4, 5 };

Console.WriteLine("Исходный массив:");
foreach (int num in original) {
    Console.Write(num + " ");  
}
Console.WriteLine();

int[] squares = SquareAll(original);

Console.WriteLine("Массив квадратов:");
foreach (int sq in squares) {
    Console.Write(sq + " ");  
}
Console.WriteLine();
//Вариант 9
int[] MergeArrays(int[] first, int[] second)
{
    int [] result = new int [first.Length + second.Length];
    for (int i = 0; i < first.Length; i++) {
        result[i] = first[i];
        }
        for (int i = 0; i < second.Length; i++) {
        result[first.Length + i] = second[i];
        }
        return result;
}
int[] array1 = { 1, 2, 3 };
int[] array2 = { 4, 5, 6, 7 };

Console.WriteLine("Первый массив:");
foreach (int num in array1) {
    Console.Write(num + " ");
}
Console.WriteLine();

Console.WriteLine("Второй массив:");
foreach (int num in array2) {
    Console.Write(num + " ");
}
Console.WriteLine();

int[] merged = MergeArrays(array1, array2);

Console.WriteLine("Объединенный массив:");
foreach (int num in merged) {
    Console.Write(num + " ");
}
