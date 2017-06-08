using ScratchConsole.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class HeadlineNotifier
    {
        public event StringDelegate HeadlineDelegate;
        private string headline;

        public string Headline
        {
            get { return headline; }
            set
            {
                headline = value;
                //As long as the value is not null nor empty, set headline
                if (!string.IsNullOrEmpty(value) && HeadlineDelegate != null)
                {
                    HeadlineDelegate.Invoke(Headline);
                }
            }
        }
    }
}
