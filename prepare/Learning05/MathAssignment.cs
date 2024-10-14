using System;
public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string student, string topic, string section, string problem) : base(student, topic)
    {
        _textBookSection = section;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}