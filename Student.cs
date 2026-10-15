namespace Task2LinqStudentAnalyzer;

public sealed class Student
{
    public string Name { get; }
    public string Grade { get; }
    public int Score { get; }

    public Student(string name, string grade, int score)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Student name cannot be empty.", nameof(name));
        if (string.IsNullOrWhiteSpace(grade))
            throw new ArgumentException("Grade category cannot be empty.", nameof(grade));
        if (score < 0 || score > 100)
            throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");

        Name = name.Trim();
        Grade = grade.Trim();
        Score = score;
    }
}
