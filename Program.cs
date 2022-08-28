using System;
using System.Linq;
using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;


//try
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine($"Результат: {y}");
//}
//catch
//{
//    Console.WriteLine("ВИникло виключення!");
//}
//finally
//{
//    Console.WriteLine("Блок finally");
//}
//Console.WriteLine("Кінець програми");

//static void Square(string data)
//{
//    int x = int.Parse(data);
//    Console.WriteLine($"Квадрат числа {x}: {x * x}");
//}

//Square("12");

//Square("ab");


//static void Square(string data)
//{
//    if (int.TryParse(data, out var x))
//    {
//        Console.WriteLine($"Квадрат числа {x}: {x * x}");
//    }
//    else
//    {
//        Console.WriteLine("Некорректный ввод");
//    }


//    Square("12");

//    Square("ab");

//}


//try
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine($"Результат: {y}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("ВИникло виключення! DivideByZeroException");
//}
//finally
//{
//    Console.WriteLine("Блок finally");
//}
//Console.WriteLine("Кінець програми");


//try
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine($"Результат: {y}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"ВИникло виключення!\n {ex.Message}");
//}


//int x = 0;
//int y = 1;
//try
//{
//    int result1 = x / y;
//    int result2 = y / x;
//}
//catch (DivideByZeroException) when (y == 0)
//{
//    Console.WriteLine("y не повинен дорівнювати 0");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения
//Message: хранит сообщение об исключении, текст ошибки
//Source: хранит имя объекта или сборки, которое вызвало исключение
//StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения
//TargetSite: возвращает метод, в котором и было вызвано исключение

//try
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine($"Результат: {y}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Исключение: {ex.Message}");
//    Console.WriteLine($"Метод: {ex.TargetSite}");
//    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
//}
//dividebyzeroexception: представляет исключение, которое генерируется при делении на ноль
//argumentoutofrangeexception: генерируется, если значение аргумента находится вне диапазона допустимых значений
//argumentexception: генерируется, если в метод для параметра передается некорректное значение
//indexoutofrangeexception: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений
//invalidcastexception: генерируется при попытке произвести недопустимые преобразования типов
//nullreferenceexception: генерируется при попытке обращения к объекту, который равен null (то есть по сути неопределен)

//try
//{
//    int[] numbers = new int[4];
//    numbers[3] = 9;     // IndexOutOfRangeException
//    int x = 5;
//    int y = x / 0;  // DivideByZeroException
//    Console.WriteLine($"Результат: {y}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Возникло исключение DivideByZeroException");
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"Исключение: {ex.Message}");
//}       

//Console.Read();


//try
//{
//    Console.Write("Введите имя: ");
//    string? name = Console.ReadLine();
//    if (name == null || name.Length < 2)
//    {
//        throw new Exception("Длина имени меньше 2 символов");
//    }
//    else
//    {
//        Console.WriteLine($"Ваше имя: {name}");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Ошибка: {e.Message}");
//}


//try
//{
//    try
//    {
//        Console.Write("Введите имя: ");
//        string? name = Console.ReadLine();
//        if (name == null || name.Length < 2)
//        {
//            throw new Exception("Длина имени меньше 2 символов");
//        }
//        else
//        {
//            Console.WriteLine($"Ваше имя: {name}");
//        }
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Ошибка: {e.Message}");
//        throw;
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try to avoid the commented code
int a, b, res;
try
{
    Console.WriteLine("Write first number");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write second number");
    b = Convert.ToInt32(Console.ReadLine());
    res = a / b;
    Console.WriteLine("result "+ res);
}
catch (DivideByZeroException)
{
//try to avoid the unnecessary whitespaces
    Console.WriteLine("Divided By Zero!!");


}
catch(FormatException)
{
    Console.WriteLine("False format");


}
