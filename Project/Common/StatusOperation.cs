using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class StatusOperation
    {
        public StatusCode Code { get; set; }
        public Exception? GetException { get; set; }
    }
}
