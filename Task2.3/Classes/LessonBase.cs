namespace Task2._3.Classes;

public abstract class LessonBase : ICloneable
{
    public string? Description { get; set; }

    public abstract object Clone();
};
