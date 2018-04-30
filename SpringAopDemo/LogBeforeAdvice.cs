﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;
using Spring.Core;

namespace SpringAopDemo
{
    public class LogBeforeAdvice : IMethodBeforeAdvice
    {
        public void Before(System.Reflection.MethodInfo method, object[] args, object target)
        {
            Console.WriteLine("拦截的方法名—>" + method.Name);
            Console.WriteLine("目标—>" + target);
            Console.WriteLine("参数—>");
            if (args != null)
            {
                foreach (object arg in args)
                {
                    Console.WriteLine("\t: " + arg);
                }
            }
        }

        
    }
}
