using System;
using System.Dynamic;
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
    }
    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    public string GetSumary()
    {
        return $"{GetStudentName()} - {GetTopic()}";
    }

    public void SetStudentName(string name)
    {
        _studentName = name;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

}