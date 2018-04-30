using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringAopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext context = ContextRegistry.GetContext();
            IStudentService command = (IStudentService)context["myStudentService"];
            command.GoToSchool("guwei4037", "一");
        }
    }
}
