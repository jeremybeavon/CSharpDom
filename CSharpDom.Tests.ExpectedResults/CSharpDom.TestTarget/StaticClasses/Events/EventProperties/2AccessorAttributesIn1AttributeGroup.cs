﻿namespace CSharpDom.TestTarget.StaticClasses.Events.EventProperties
{
    public static class StaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
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
