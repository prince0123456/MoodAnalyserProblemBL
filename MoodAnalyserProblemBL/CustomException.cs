using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblemBL
{
    internal class CustomException : Exception
    {
        public enum Mood
        {
            Empty,
            Null
        }

        public readonly Mood Minfo;

        public CustomException(Mood minfo, string info) : base(info)
        {
            this.Minfo = minfo;
        }


       
        ExceptionType type;
        public enum ExceptionType
        {
            NULL, EMPTY, NO_SUCH_CLASS, NO_SUCH_CONSTRUCTOR, NO_SUCH_METHOD
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
