﻿namespace CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads
{
    public struct StructWithNestedClassWithLeftShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
