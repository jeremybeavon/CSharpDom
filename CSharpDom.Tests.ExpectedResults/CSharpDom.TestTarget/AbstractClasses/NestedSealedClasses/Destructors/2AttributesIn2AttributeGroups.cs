﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Destructors
{
    public abstract class AbstractClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
