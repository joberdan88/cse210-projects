using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}