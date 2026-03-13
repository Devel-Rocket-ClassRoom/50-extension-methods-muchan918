using System;

string input = "  hello world  ";

// 방법 1: 중첩 호출 (읽기 어려움)
string result1 = StringExtensions.Replace(
    StringExtensions.Upper(
        StringExtensions.Trim(input)), ' ', '_');

// 방법 2: 메서드 체이닝 (읽기 쉬움)
string result2 = input
    .Trim()
    .Upper()
    .Replace(' ', '_');

Console.WriteLine($"결과1: {result1}");
Console.WriteLine($"결과2: {result2}");

SecretBox box = new SecretBox();
box.ShowData();

Greeter g = new Greeter();
g.SayHello();
g.SayGoodBye();

GreeterExtensions.SayHello(g);