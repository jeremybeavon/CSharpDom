﻿namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Destructors
{
    public static class StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
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
