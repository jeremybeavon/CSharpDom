﻿namespace CSharpDom.TestTarget.Classes.NestedClasses.ConversionOperators
{
    public class ClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
