using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyze_Testing1
{
    internal class MoodAnalyzer
    {

        [TestClass]
        public class UnitTest1
        {
            private MoodAnalyzer moodAnalyzer;

            //public UnitTest1()
            //{
            //     moodAnalyzer = new MoodAnalyzer();
            //}

            [TestMethod]
            public void TestMethod1()
            {
                // >> arrange
                moodAnalyzer = new MoodAnalyzer();
                // >> Act
                var Result = moodAnalyzer.AnalyzeMood("I am in Happy Mood");
                // >> Assert
                Assert.AreEqual(Result, "Happy");
            }
        }

        private object AnalyzeMood(string v)
        {
            throw new System.NotImplementedException();
        }
    }
}