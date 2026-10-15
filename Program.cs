using Task2LinqStudentAnalyzer;

List<Student> students =
[
    new Student("Aarav", "A", 92),
    new Student("Diya", "A", 88),
    new Student("Kabir", "B", 79),
    new Student("Meera", "A", 95),
    new Student("Rohan", "C", 64),
    new Student("Sara", "B", 82),
    new Student("Vivaan", "C", 58),
    new Student("Anaya", "B", 76)
];

Console.WriteLine("STUDENT RECORDS ANALYZER");
Console.WriteLine("========================");

Console.WriteLine();
Console.WriteLine("1. Students scoring 80 or above (Where):");
var highScorers = students
    .Where(student => student.Score >= 80)
    .Select(student => new { student.Name, student.Score });
foreach (var student in highScorers)
    Console.WriteLine($"- {student.Name}: {student.Score}");

Console.WriteLine();
Console.WriteLine("2. Student names and scores (Select):");
var studentSummaries = students.Select(student => $"{student.Name} — {student.Score}");
foreach (string summary in studentSummaries)
    Console.WriteLine($"- {summary}");

Console.WriteLine();
Console.WriteLine("3. Students ordered by score, lowest first (OrderBy):");
var orderedStudents = students
    .OrderBy(student => student.Score)
    .Select(student => $"{student.Name}: {student.Score}");
foreach (string student in orderedStudents)
    Console.WriteLine($"- {student}");

Console.WriteLine();
Console.WriteLine("4. Number of students in each grade category (GroupBy):");
var gradeCounts = students
    .GroupBy(student => student.Grade)
    .OrderBy(group => group.Key)
    .Select(group => new { Grade = group.Key, Count = group.Count() });
foreach (var group in gradeCounts)
    Console.WriteLine($"- Grade {group.Grade}: {group.Count} student(s)");

Console.WriteLine();
Console.WriteLine("5. Aggregate results:");
Console.WriteLine($"- Total students: {students.Count()}");
Console.WriteLine($"- Average score: {students.Average(student => student.Score):F2}");
Console.WriteLine($"- Highest score: {students.Max(student => student.Score)}");
Console.WriteLine($"- Lowest score: {students.Min(student => student.Score)}");
