int randomNumber= new Random().Next(100, 1000);
Console.WriteLine ($"Трехзначное число=> {randomNumber}");//итнрополяция строки
int finishNumber=GetNumber(randomNumber);
Console.WriteLine($"Первое и конечное число=> {finishNumber}");

int GetNumber(int number)
{
    int firstNumber=number/100;
    int secondNumber=number%10;
    int result=firstNumber*10+secondNumber;
    return result;
}