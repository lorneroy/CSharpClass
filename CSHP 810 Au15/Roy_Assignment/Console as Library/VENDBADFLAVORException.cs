using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._0_Console_As_Library
{
    public class VENDBADFLAVORException : Exception
    {
        public VENDBADFLAVORException()
            : base("Bad Conversion to a Flavor enumeral attempted")
        {
        }

        public VENDBADFLAVORException(string Message, string BadFlavorString)
            : base(string.Format("{0}:{1}",Message,BadFlavorString))
        {
        }
    }
}
