﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public static class Class
        {
            public static event EventHandler Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
