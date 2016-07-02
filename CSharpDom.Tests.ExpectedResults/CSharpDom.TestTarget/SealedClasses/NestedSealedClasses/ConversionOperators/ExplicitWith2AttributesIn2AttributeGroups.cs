namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
