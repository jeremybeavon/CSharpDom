﻿namespace CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads
{
    public class ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public class Class
        {
            public static bool operator <(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator >(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
