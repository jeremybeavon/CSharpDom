﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStaticClassWithEventPropertyWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
