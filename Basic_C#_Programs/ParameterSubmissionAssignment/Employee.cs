using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSubmissionAssignment
{
    class Employee<T>
    {
        public List<T> things { get; set; }
    }
}
