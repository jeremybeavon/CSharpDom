﻿namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
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
