using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3.Classes
{
    public class Trainig : Lesson
    {
        Lesson[] _lessons = new Lesson[2];
        int _lastLessonNumer = 0;

        public void Add(Lesson lesson)
        {
            if (_lastLessonNumer == _lessons.Length - 1)
            {
                var newLessons = new Lesson[_lessons.Length * 2];
                _lessons.CopyTo(newLessons, 0);
                _lessons = newLessons;
            }
            _lessons[_lastLessonNumer++] = lesson;
        }

        public bool IsPractical()
        {
            if (_lastLessonNumer == 0)
            {
                return false;
            }

            bool isPractical = true;

            foreach (var lesson in _lessons)
            {
                if (lesson is not PracticalLesson)
                {
                    isPractical = false;
                    break;
                }
            }
            return isPractical;
        }

        public void Clone(Trainig trainingToCopy)
        {
            foreach (var lesson in _lessons)
            {
                if (lesson == null)
                {
                    return;
                }
                switch (lesson)
                {
                    case PracticalLesson practice:
                        trainingToCopy.Add(new PracticalLesson()
                        {
                            Description = practice.Description,
                            LinkToTheSolution = practice.LinkToTheSolution,
                            LinkToTheTask = practice.LinkToTheTask
                        });
                        break;

                    case Lecture lecture:
                        trainingToCopy.Add(new Lecture()
                        {
                            Description = lecture.Description,
                            Topic = lecture.Topic
                        });
                        break;
                }
            }
        }
    }
}
