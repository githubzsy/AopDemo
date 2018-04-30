using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAopDemo
{
    public interface IStudentService
    {
        void GoToSchool(string studentName, string className);
    }
}
