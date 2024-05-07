namespace Task2._3.Classes;

public class Lecture : LessonBase
{
    public string? Topic { get; set; }

    public override object Clone()
    {
        return new Lecture()
        {
            Topic = Topic,
            Description = Description,
        };
    }
};
