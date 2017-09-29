namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static explicit operator PartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup(string text)
        {
            return default(PartialClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup);
        }
    }
}
