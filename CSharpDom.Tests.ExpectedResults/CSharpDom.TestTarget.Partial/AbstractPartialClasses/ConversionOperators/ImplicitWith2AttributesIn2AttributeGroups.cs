﻿namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static implicit operator AbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(AbstractPartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
