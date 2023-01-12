using System;

namespace Session_04
{
    public class SecondsConversion
    {
        double seconds = 45678;
        public string ConvertSecondsToDateTime()
        {
           
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            string conversion = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            return(conversion);
        }

        public void PrintConversion() 
        { 
            Console.WriteLine($"{seconds} seconds is: {ConvertSecondsToDateTime()}");
        }
    }
}