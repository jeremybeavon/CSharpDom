﻿namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
