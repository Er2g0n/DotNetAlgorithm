
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//Bai 1

Console.WriteLine("Practice 1:");
List<string> students = new List<string>() {"Hai","Linh", "Kelly" };
students.Insert(1,"Ha");
Console.WriteLine("List affter Add");
Console.WriteLine(string.Join(", " ,students));
students.RemoveAt(2);
Console.WriteLine("List affter Remove");
Console.WriteLine(string.Join(", ",students));
string searchName = "Kelly"; 
foreach (string student in students)
{
    if (student == searchName)
    {
        Console.WriteLine($"Found Name : {searchName}");
    }
    else {
        Console.WriteLine("Not Found");
     }
}
//Bai 2
Console.WriteLine("Practice 2:");
Dictionary<string, int> studentScores = new Dictionary<string, int>()
{
    {"Hai",9},
    {"Kelly",4},
        {"Ha",5},
    {"Ho",10},

};
Console.WriteLine("List of student greater than 8");
foreach (var studentScore in studentScores)
{
    if (studentScore.Value>8)
    {
        Console.WriteLine($"Student that have score greater than 8 is: {studentScore.Key}:{studentScore.Value}");
    }
}
Console.WriteLine("Hello");
//Bai 3
Console.WriteLine("Practice 3: compete the performance between arrayList and List");
const int itemCount = 1000000;
ArrayList arrayList = new ArrayList();
for (int i = 0; i < itemCount; i++)
{
    arrayList.Add(i);
}
List<int> list = new List<int>();
for (int i = 0;i < itemCount; i++)
{
    list.Add(i);
}
Stopwatch sw =  Stopwatch.StartNew();
foreach (int item in arrayList)
{
    int value = item;
}
sw.Stop();
Console.WriteLine($"Time spent on ArrayList: {sw.ElapsedMilliseconds} ms");
sw.Restart();
foreach (int item in list)
{
    int value = item;

}
sw.Stop();
Console.WriteLine($"Time spent on List<int>: {sw.ElapsedMilliseconds} ms");
