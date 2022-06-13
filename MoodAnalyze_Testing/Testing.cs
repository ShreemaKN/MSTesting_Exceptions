using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyze_Testing
{
    
    public class Testing
    {
        private MoodAnalyzer moodAnalyzer;

        public Testing()
        {
            moodAnalyzer = new MoodAnalyzer();
        }

       
        public void TestMethod()
        {

            moodAnalyzer = new MoodAnalyzer();
            var Result = moodAnalyzer.AnalyzeMood("I am in Happy Mood");
            Assert.AreEqual(Result, "HAPPY");
        }
    }
}
