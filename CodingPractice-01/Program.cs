using System;
using System.Linq;

string message = "안녕하세요 반갑습니다";
int count = StringHelper.CountWords(message);
Console.WriteLine($"단어 개수: {count}");

message = "안녕하세요 반갑습니다";
count = message.CountWords();
Console.WriteLine($"단어 개수: {count}");

int num1 = 10;
int num2 = 7;

Console.WriteLine($"{num1}은(는) 짝수인가? {num1.IsEven()}");
Console.WriteLine($"{num2}은(는) 홀수인가? {num2.IsOdd()}");
Console.WriteLine($"3을 5번 반복: {3.Repeat(5)}");