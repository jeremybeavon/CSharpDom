﻿namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Events
{
    public struct StructWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}