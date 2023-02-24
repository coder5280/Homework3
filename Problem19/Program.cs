//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

    void Palindrome(string[] args)
    {
        int number = 14212;
        int remainder;
        int sum = 0;
        int temporary = number;
        while (number > 0)
        {  
            remainder = number % 10;
            sum = (sum * 10) + remainder;
            number = number / 10;
        }
        if (temporary == sum)
        {
            Console.WriteLine($"Number {temporary} is Palindrome.");
        }
        else
        {
            Console.WriteLine($"Number {temporary} is not Palindrome");
        }
    }
    Palindrome(args);