﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.Clear();
Console.WriteLine("Введите любое чило и узнаешь, является ли оно четным: ");

int num = int.Parse(Console.ReadLine());
if(num % 2 == 0) {
    Console.Write("Значение '" + num + "' является четным");
}
else {
    Console.Write("Это число не является четным! Попробуйещё раз!");
}