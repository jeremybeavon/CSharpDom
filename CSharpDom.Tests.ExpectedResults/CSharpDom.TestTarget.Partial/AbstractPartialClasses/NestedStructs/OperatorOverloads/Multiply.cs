﻿namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithMultiplyOperatorOverload
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
