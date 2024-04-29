using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3.Classes
{
    public record PracticalLesson (string? Description, string? LinkToTheTask,
        string? LinkToTheSolution) : Lesson(Description);
}
