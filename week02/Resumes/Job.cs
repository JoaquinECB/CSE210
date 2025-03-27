public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Start Year: {_startYear}");
        Console.WriteLine($"End Year: {_endYear}");
    }
}