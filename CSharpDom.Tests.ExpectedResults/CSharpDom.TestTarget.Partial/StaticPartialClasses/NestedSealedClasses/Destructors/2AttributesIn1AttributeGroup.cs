﻿namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Destructors
{
    public static partial class StaticPartialClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
