﻿namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators
{
    public static class StaticClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
