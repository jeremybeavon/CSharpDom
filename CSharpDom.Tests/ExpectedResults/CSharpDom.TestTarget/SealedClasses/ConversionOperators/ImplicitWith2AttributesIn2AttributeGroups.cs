namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
