// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
// для случайных чисел
Console.Clear();
 int N = 10, sum = 0; // размер массива и переменная для подсчета количества положительных элементов
        int[] A = new int[N];   // объявление массива и выделение памяти под него
        Random r = new Random();    // объект для генерации случайных чисел
 
        for (int i = 0; i < N; i++)
        {
            A[i] = r.Next(-10, 10);   // инициализируем элементы массива случайными значениями из диапазона [-10, 10)
            Console.Write(A[i] + " ");    //  и выводим их
            if (A[i] > 0)   // если элемент положительный
                sum ++;    // то прибавляем к счетчику 1
        }
  Console.WriteLine("\n" + sum);

// для ввода с клавиатуры
Console.Write("How many numbers to enter:");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter {i + 1} number: ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0) count++;
}
Console.WriteLine($"\nEntered{count} numbers greater than zero/\n");
        