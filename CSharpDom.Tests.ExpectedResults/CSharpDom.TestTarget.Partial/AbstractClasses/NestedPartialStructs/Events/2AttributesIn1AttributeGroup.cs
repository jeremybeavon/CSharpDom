﻿namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events
{
    public abstract class AbstractClassWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
