namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static implicit operator ClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
