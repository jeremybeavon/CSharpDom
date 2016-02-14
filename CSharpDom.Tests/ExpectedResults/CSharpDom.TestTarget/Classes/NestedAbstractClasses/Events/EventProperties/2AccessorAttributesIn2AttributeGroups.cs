﻿namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors
{
    public class ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            public event EventHandler Event
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
}
