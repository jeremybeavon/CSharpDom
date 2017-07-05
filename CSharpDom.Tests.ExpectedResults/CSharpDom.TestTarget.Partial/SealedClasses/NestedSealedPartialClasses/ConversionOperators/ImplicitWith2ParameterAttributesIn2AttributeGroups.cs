namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
