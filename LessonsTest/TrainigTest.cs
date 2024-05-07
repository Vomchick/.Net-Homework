using Task2._3.Classes;

namespace LessonsTest
{
    [TestClass]
    public class TrainingTest
    {
        [TestMethod]
        public void TrainigAdd()
        {
            var training1 = new Training();
            training1.Add(new Lecture()
            {
                Description = null,
                Topic = ".Net-Course"
            });
            training1.Add(new PracticalLesson());

            Assert.IsTrue(training1.Lessons[0] != null);
            Assert.IsTrue(training1.Lessons[1] != null);

            training1.Add(new Lecture() 
            {
                Description = null,
                Topic = "Java-course"
            });
            Assert.IsTrue(training1.Lessons.Length == 4);
            Assert.IsTrue(training1.Lessons[2] != null);
            Assert.IsTrue(training1.Lessons[3] == null);
        }

        [TestMethod]
        public void TrainigIsPractical()
        {
            var training1 = new Training();
            Assert.IsFalse(training1.IsPractical());

            training1.Add(new Lecture()
            {
                Description = null,
                Topic = ".Net-Course"
            });
            training1.Add(new PracticalLesson());

            Assert.IsFalse(training1.IsPractical());

            var training2 = new Training();
            training2.Add(new PracticalLesson());
            training2.Add(new PracticalLesson());

            Assert.IsTrue(training2.IsPractical());
        }


        [TestMethod]
        public void TrainigClone()
        {
            var training1 = new Training();
            training1.Add(new Lecture()
            {
                Description = "Something very important",
                Topic = ".Net-Course"
            });
            training1.Add(new PracticalLesson());
            
            var cloned = (Training) training1.Clone();

            Assert.IsFalse(training1 == cloned);
            Assert.IsFalse(training1.Lessons[0] == cloned.Lessons[0]);
            Assert.IsTrue(training1.Lessons[0].Description == cloned.Lessons[0].Description);
        }
    }
}