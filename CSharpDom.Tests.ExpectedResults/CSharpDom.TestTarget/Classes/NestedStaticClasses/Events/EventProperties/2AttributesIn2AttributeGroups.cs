﻿namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Constructors
{
    public class ClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
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