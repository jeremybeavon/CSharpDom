﻿namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Destructors
{
    public sealed class SealedClassWithNestedSealedPartialClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
