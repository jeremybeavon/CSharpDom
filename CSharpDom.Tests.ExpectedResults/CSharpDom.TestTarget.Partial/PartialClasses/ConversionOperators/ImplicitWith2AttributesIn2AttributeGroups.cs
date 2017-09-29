namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static implicit operator PartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(PartialClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
