namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
