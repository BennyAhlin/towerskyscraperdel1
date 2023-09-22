var floor = 5;
var sum4 = floor / 10; // 5/10 = 0,5 = 1 
var sum13 = floor / 100; // 5/100 = 0,05 = 0
var sumAll = 0;
if (floor % 100 == 13 || floor % 10 == 4)
{
    Console.WriteLine("kan ej omvandla till riktigt våningsnummer");
}
else
{
    if (floor % 10 < 4)
    {
        sumAll = sumAll + sum4;
    }
    else if (floor % 10 >= 4)
    {
        sumAll = sumAll + sum4 + 1;
    }
    if (floor % 100 < 13)
    {
        sumAll = sumAll + sum13;
    }
    else if (floor % 100 >= 13)
    {
        sumAll = sumAll + sum13 + 1;
    }
    floor = floor - sumAll;
    Console.WriteLine(floor);
}