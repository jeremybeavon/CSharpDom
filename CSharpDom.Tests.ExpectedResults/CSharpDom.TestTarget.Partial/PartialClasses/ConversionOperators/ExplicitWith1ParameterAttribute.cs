﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator ClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(ClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
