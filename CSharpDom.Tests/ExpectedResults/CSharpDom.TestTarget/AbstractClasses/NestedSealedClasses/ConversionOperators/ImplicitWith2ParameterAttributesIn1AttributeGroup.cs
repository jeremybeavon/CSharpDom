﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
