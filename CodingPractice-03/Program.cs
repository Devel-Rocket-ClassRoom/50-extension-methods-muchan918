using System;
using System.Collections.Generic;

string word = "hello";
Console.WriteLine($"'{word}' 대문자로 시작? {word.IsCapitalized()}");
Console.WriteLine($"첫 글자 대문자: {word.Capitalize()}");
Console.WriteLine($"뒤집기: {word.Reverse()}");

string original = "안녕하세요 반갑습니다 좋은 하루 되세요";
string result = original
    .Take(10)
    .AddEllipsis()
    .AddPrefix("[메시지] ")
    .AddSuffix(" (더보기)");

Console.WriteLine($"원본: {original}");
Console.WriteLine($"결과: {result}");

string[] names = { "철수", "영희", "민수" };
List<int> emptyList = new List<int>();

Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
Console.WriteLine($"names에 요소 있음? {names.HasItems()}");

Console.WriteLine("\n이름 목록:");
names.ForEach(name => Console.WriteLine($"  - {name}"));