﻿namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
