﻿namespace CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads
{
    public class ClassWithNestedClassWithOrOperatorOverload
    {
        public class Class
        {
            public static Class operator |(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
