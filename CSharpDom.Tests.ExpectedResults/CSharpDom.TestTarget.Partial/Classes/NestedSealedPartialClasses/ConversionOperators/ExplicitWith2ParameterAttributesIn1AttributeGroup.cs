﻿namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.ConversionOperators
{
    public class ClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
