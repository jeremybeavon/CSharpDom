﻿namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Destructors
{
    public class ClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
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
