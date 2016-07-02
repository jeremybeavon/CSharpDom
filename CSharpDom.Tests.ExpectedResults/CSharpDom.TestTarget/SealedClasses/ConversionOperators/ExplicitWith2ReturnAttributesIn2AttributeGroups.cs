namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
