namespace Task2._3.Classes;

public class PracticalLesson : LessonBase
{ 
    public string? LinkToTheTask { get; set; }
    public string? LinkToTheSolution { get; set; }

    public override object Clone()
    {
        return new PracticalLesson() { 
            Description = Description, 
            LinkToTheTask = LinkToTheTask, 
            LinkToTheSolution = LinkToTheSolution 
        };
    }
};
