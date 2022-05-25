int number = new Random().Next(10, 100); // Присваевает рандомнре значение от 10 до 99 переменной 
Console.WriteLine($"Number = {number}"); // Выводит на экран эту переменную. Что бы написать все в одну строку (и текст и вывод переменной) использовать $ и {}
int firstDigit = number / 10; // Поделив на десять найдем первую цифру двузначного числа 
int secondDigit = number % 10; // Так находим вторую цифру в двузначном числе 
Console.WriteLine($"Number 1 = { firstDigit }");
Console.WriteLine($"Number 2 = { secondDigit }");

Console.WriteLine( firstDigit > secondDigit ? $" Max = {firstDigit}" : $" Max = {secondDigit}"); // "?" вместо if и else, а ":" означает или