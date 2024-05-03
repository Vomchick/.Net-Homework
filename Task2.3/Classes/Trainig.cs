namespace Task2._3.Classes;

public class Trainig : TrainigBase
{
    public LessonBase[] Lessons { get; private set; } = new LessonBase[2];
    int _lessonsCount = 0;

    public void Add(LessonBase lesson)
    {
        if (_lessonsCount == Lessons.Length - 1)
        {
            var newLessons = new LessonBase[Lessons.Length * 2];
            Lessons.CopyTo(newLessons, 0);
            Lessons = newLessons;
        }
        Lessons[_lessonsCount++] = lesson;
    }

    public bool IsPractical()
    {
        if (_lessonsCount == 0)
        {
            return false;
        }

        bool isPractical = true;

        for (int i = 0; i < _lessonsCount; i++)
        {
            if (Lessons[i] is not PracticalLesson)
            {
                isPractical = false;
                break;
            }
        }
        return isPractical;
    }

    public override object Clone()
    {
        var clonedTrainig = new Trainig()
        {
            Description = Description,
            _lessonsCount = _lessonsCount,
        };

        var clonedLessons = new LessonBase[Lessons.Length];
        for (int i = 0;i < _lessonsCount; i++)
        {
            clonedLessons[i] = (LessonBase)Lessons[i].Clone();
        }

        clonedTrainig.Lessons = clonedLessons;
        return clonedTrainig;
    }
}
