﻿namespace CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithIncrementOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator ++(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
