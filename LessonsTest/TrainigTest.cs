using Task2._3.Classes;

namespace LessonsTest
{
    [TestClass]
    public class TrainingTest
    {
        [TestMethod]
        public void TrainigAdd()
        {
            var training1 = new Trainig();
            training1.Add(new Lecture(null, ".Net-Course"));
            training1.Add(new PracticalLesson(null, null, null));

            Assert.IsTrue(training1.Lessons[0] != null);
            Assert.IsTrue(training1.Lessons[1] != null);

            training1.Add(new Lecture(null, "Java-Course"));
            Assert.IsTrue(training1.Lessons.Length == 4);
            Assert.IsTrue(training1.Lessons[2] != null);
            Assert.IsTrue(training1.Lessons[3] == null);
        }

        [TestMethod]
        public void TrainigIsPractical()
        {
            var training1 = new Trainig();
            Assert.IsFalse(training1.IsPractical());

            training1.Add(new Lecture(null, ".Net-Course"));
            training1.Add(new PracticalLesson(null, null, null));

            Assert.IsFalse(training1.IsPractical());

            var training2 = new Trainig();
            training2.Add(new PracticalLesson(null, null, null));
            training2.Add(new PracticalLesson(null, null, null));

            Assert.IsTrue(training2.IsPractical());
        }


        [TestMethod]
        public void TrainigClone()
        {
            var training1 = new Trainig();
            training1.Add(new Lecture(null, ".Net-Course"));
            training1.Add(new PracticalLesson(null, null, null));
            var training2 = new Trainig();

            training1.Clone(training2);

            Assert.IsFalse(training1 == training2);
            for (int i = 0; i < training1.Lessons.Length; i++)
            {
                Assert.IsTrue(training1.Lessons[i] == training2.Lessons[i]);
            }
        }
    }
}