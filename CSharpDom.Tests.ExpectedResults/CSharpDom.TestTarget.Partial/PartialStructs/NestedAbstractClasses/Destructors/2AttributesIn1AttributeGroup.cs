﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Destructors
{
    public partial struct PartialStructWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroup
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
