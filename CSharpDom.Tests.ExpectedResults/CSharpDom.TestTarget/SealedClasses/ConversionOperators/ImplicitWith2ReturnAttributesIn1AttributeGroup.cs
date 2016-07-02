namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
