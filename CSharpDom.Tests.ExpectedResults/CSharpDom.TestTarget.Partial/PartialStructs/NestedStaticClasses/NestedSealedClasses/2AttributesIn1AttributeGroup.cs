﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedSealedClasses
{
    public partial struct PartialStructWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
