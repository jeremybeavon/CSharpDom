﻿namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
