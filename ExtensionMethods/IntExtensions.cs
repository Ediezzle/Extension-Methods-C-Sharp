using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    //Extension methods need to be in a static class
    static class IntExtensions
    {
        //defining a static method as an extension method 
        //the first parameter of the extension method specifies the type on which the extension method is applicable so the first parameter must be int, preceded with the this modifier.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
