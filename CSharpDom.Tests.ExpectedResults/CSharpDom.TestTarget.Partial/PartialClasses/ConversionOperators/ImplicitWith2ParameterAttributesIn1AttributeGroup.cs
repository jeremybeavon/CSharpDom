﻿namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public static implicit operator PartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup([Attribute1, Attribute2]string text)
        {
            return default(PartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup);
        }
    }
}
