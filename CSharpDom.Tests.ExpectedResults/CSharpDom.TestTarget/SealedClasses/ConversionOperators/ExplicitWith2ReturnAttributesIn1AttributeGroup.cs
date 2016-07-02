namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static explicit operator SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
