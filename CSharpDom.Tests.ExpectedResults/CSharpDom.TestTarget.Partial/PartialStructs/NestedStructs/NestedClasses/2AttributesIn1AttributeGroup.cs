﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedClasses
{
    public partial struct PartialStructWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
