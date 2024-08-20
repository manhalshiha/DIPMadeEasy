using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkLogger.Abstractions
{
    public abstract class CwkAbstractLogger
    {
        public abstract void Log(string message);
    }
}
