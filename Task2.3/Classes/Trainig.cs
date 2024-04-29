using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3.Classes
{
    public class Trainig
    {
        string? Description;
        public Lesson[] Lessons { get; private set; } = new Lesson[2];
        int _lessonsCount = 0;

        public void Add(Lesson lesson)
        {
            if (_lessonsCount == Lessons.Length - 1)
            {
                var newLessons = new Lesson[Lessons.Length * 2];
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

        public void Clone(Trainig trainingToCopy)
        {
            for (int i = 0; i < _lessonsCount; i++)
            {
                if (Lessons[i] == null)
                {
                    return;
                }
                switch (Lessons[i])
                {
                    case PracticalLesson practice:
                        trainingToCopy.Add(new PracticalLesson(
                            practice.Description,
                            practice.LinkToTheSolution,
                            practice.LinkToTheTask
                        ));
                        break;

                    case Lecture lecture:
                        trainingToCopy.Add(new Lecture(
                            lecture.Description,
                            lecture.Topic
                        ));
                        break;
                }
            }
        }
    }
}
