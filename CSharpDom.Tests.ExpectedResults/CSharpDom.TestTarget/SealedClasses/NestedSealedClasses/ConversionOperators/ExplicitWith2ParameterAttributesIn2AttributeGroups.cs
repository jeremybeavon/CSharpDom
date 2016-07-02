namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
