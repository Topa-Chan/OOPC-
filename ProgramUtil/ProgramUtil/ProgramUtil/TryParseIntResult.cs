using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUtilLib
{
    public class TryParseIntResult
    {

        public readonly bool didParse;
        public readonly int? result;

        public TryParseIntResult(bool didParse, int? result)
        {
            if (didParse)
            {
                this.didParse = didParse;
                this.result = result;
            }
            else
            {
                this.didParse = didParse;
                this.result = null;
            }
        }
        
        public override string ToString()
        {
            return "" + result;
        }
    }
}
