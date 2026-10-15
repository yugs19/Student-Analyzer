# Task 2 — LINQ Student Records Analyzer

A small .NET 8 console application that answers questions about student records using LINQ.

## Requirements covered

- `Where` filters students scoring 80 or above.
- `Select` projects records into concise summaries.
- `OrderBy` sorts students from lowest score to highest score.
- `GroupBy` groups students by grade category.
- Aggregate queries use `Count`, `Average`, `Max`, and `Min`.
- Every output section has a descriptive label.
- The student model uses properties and validates constructor inputs.

## Requirements

Install the .NET 8 SDK: https://dotnet.microsoft.com/download/dotnet/8.0

## Run the project

Open a terminal in the directory containing `Task2LinqStudentAnalyzer.csproj` and run:

```bash
dotnet restore
dotnet build
dotnet run
```

## Example output

```text
STUDENT RECORDS ANALYZER
========================

1. Students scoring 80 or above (Where):
- Aarav: 92
- Diya: 88
- Meera: 95
- Sara: 82

2. Student names and scores (Select):
- Aarav — 92
- Diya — 88
- Kabir — 79
- Meera — 95
- Rohan — 64
- Sara — 82
- Vivaan — 58
- Anaya — 76

3. Students ordered by score, lowest first (OrderBy):
- Meera: 95
- Aarav: 92
- Diya: 88
- Sara: 82
- Kabir: 79
- Anaya: 76
- Rohan: 64
- Vivaan: 58

4. Number of students in each grade category (GroupBy):
- Grade A: 3 student(s)
- Grade B: 3 student(s)
- Grade C: 2 student(s)

5. Aggregate results:
- Total students: 8
- Average score: 79.25
- Highest score: 95
- Lowest score: 58
```

## Design decisions

- The sample uses eight in-memory student records, so no database or external dataset is needed.
- Scores are validated to be between 0 and 100.
- `OrderBy` is used to sort scores in ascending order, making the ranking easy to read from lowest to highest.
- `Count`, `Average`, `Max`, and `Min` demonstrate aggregate operations.
- `foreach` is used only to print query results. Filtering, projection, sorting, grouping, and aggregation are performed using LINQ.

## Files

- `Program.cs` — sample data and LINQ queries.
- `Student.cs` — student model and constructor validation.
- `Task2LinqStudentAnalyzer.csproj` — .NET project configuration.
- `.gitignore` — excludes generated build files.
