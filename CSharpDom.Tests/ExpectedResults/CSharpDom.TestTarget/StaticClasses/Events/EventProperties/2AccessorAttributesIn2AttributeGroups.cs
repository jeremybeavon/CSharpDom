﻿namespace CSharpDom.TestTarget.StaticClasses.Constructors
{
    public static class StaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public static event EventHandler Event
        {
            [Attribute1]
            [Attribute2]
            add { }
            [Attribute1]
            [Attribute2]
            remove { }
        }
    }
}
