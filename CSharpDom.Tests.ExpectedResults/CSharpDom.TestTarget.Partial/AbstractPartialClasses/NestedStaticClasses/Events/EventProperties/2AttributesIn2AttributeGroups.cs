﻿namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
