﻿namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums
{
    public struct StructWithNestedStructWithNestedEnumWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public enum Enum
            {
            }
        }
    }
}
