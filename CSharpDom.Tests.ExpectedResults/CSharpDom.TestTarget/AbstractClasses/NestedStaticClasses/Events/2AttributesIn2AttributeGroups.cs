﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events
{
    public abstract class AbstractClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
