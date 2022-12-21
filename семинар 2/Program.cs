                                        //Задача 10
    
   /* int ParseSecondDigitNumber(int num) => (num / 10)
     % 10;
Console.Write("Введите 3-ех значное число: ");
    var num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {ParseSecondDigitNumber(num)}"); */

                                        //Задача 15

   /* bool Day(short numDayOfWeek) => 
            numDayOfWeek == 6 ||
            numDayOfWeek == 7; 
Console.Write("Введите номер дня недели: ");
    var numDayOfWeek = short.Parse(Console.ReadLine());
    if (Day(numDayOfWeek))
Console.WriteLine($"{numDayOfWeek} -> да");
    else
Console.WriteLine($"{numDayOfWeek} -> нет");*/

                                            //Задача 13

/*bool TryParseThirdDigit(string num, out int result)
{
    result = default;
    if (num.Length < 3)
        return false;

    result = int.Parse(
        num.ElementAt(2) 
           .ToString() 

    return true;
}

Console.Write("Введите число: ");
var num = Console.ReadLine();

if (TryParseThirdDigit(num, out int thirdDigit))
    Console.WriteLine($"{num} -> {thirdDigit}");
else
    Console.WriteLine($"{num} -> третьей цифры нет"); */