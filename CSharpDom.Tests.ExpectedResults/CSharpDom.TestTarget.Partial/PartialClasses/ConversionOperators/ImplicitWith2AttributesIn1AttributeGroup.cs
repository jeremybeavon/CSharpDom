namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static implicit operator ClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
