using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblemBL
{
    internal class MoodAnalyse
    {
        public string Info;
        public MoodAnalyse(string info)
        {
            this.Info = info;
        }
        public string AnalyseEmptyMood()
        {
            try
            {
                if (this.Info.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.Mood.Empty, "Its Empty");
                }
            }


            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.Mood.Empty, "Its Empty");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
            return null;
        }
        public string AnalyseNullMood()
        {


            try
            {
                if (this.Info == null)
                {
                    throw new CustomException(CustomException.Mood.Null, "Its Null");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.Mood.Null, "Its Null");
            }
            catch (CustomException ex1)
            {
                Console.WriteLine(ex1.Message);
                return ex1.Message;
            }
            return null;
        }

        public string AnalyseMood()
        {
            try
            {
                if (Info.Contains("sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }
}
