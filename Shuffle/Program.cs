using System;
using System.Collections.Generic;

Console.WriteLine("=== 컬렉션 셔플 테스트 ===");
List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine();
Console.WriteLine("[숫자 리스트 셔플]");
Console.WriteLine($"원본: {String.Join(", ", list)}");
Console.WriteLine($"셔플: {String.Join(", ", list.Shuffle())}");
Console.WriteLine();

Console.WriteLine("[카드 덱 셔플]");
List<string> listCard = new List<string>() { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine($"원본: {String.Join(", ", listCard)}");
Console.WriteLine($"셔플: {String.Join(", ", listCard.Shuffle())}");
Console.WriteLine();

Console.WriteLine("[학생 순서 무작위 배치]");
List<string> listStudent = new List<string>() { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine($"원본: {String.Join(", ", listStudent)}");
Console.WriteLine($"셔플: {String.Join(", ", listStudent.Shuffle())}");
