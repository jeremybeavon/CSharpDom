﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithMultiplyOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator *(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
