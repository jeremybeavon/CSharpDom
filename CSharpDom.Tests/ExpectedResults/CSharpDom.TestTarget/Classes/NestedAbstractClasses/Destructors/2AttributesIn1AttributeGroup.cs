﻿namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Destructors
{
    public class ClassWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
