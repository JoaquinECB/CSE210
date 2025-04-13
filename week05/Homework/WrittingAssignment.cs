using System;

class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Llama al constructor de la clase base
    {
        _title = title;
    }

    // Method to get writing information
    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - \"{_title}\"";
    }
}