﻿namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Constructors
{
    public sealed class SealedClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
