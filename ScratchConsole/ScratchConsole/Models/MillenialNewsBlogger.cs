using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class MillenialNewsBlogger
    {

        private static void PostStory(string allegedTruth)
        {
            Console.WriteLine("Big Brother just said: \"" + allegedTruth + "\"... but it's not what you think!");
        }

        public static void TrustNewsSoruce(HeadlineNotifier source)
        {
            source.HeadlineDelegate += PostStory;
        }

    }
}
