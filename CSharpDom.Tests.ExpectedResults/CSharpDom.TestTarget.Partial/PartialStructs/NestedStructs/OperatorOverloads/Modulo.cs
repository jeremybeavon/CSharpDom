﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.OperatorOverloads
{
    public partial struct PartialStructWithNestedStructWithModuloOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator %(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
