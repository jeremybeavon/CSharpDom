﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events
{
    public partial struct PartialStructWithNestedStaticClassWithEventWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
