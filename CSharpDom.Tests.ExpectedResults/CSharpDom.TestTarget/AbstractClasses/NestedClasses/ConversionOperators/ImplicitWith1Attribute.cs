﻿namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedClassWithImplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
