using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3.Classes
{
    public record Lecture (string? Description, string? Topic) : Lesson(Description);
}
