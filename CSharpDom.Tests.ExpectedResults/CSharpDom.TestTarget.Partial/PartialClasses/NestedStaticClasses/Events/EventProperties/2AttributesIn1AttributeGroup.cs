﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
