namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
