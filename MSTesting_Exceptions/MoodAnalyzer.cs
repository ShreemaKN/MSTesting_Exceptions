using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTesting_Exceptions
{
    internal class MoodAnalyzer
    {

        public string AnalyzeMood(string message)
        {
            if(message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else 
            {
                return "HAPPY";
            }
        }
    }
}
