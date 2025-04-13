using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Test the base Assignment class
        Assignment assignment1 = new Assignment("John Doe", "Math Homework");
        Console.WriteLine(assignment1.GetSummary());

        // Test the MathAssignment class
        MathAssignment mathAssignment1 = new MathAssignment("Jane Smith", "Algebra", "Section 2.3", "Problems 1-10");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        // Test the WritingAssignment class
        WritingAssignment writingAssignment1 = new WritingAssignment("Emily Johnson", "History", "The Civil War");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}