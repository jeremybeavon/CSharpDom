﻿namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
