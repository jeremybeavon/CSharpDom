﻿namespace CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads
{
    public struct StructWithNestedClassWithEqualAndNotEqualOperatorOverloads
    {
        public class Class
        {
            public static bool operator ==(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator !=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
