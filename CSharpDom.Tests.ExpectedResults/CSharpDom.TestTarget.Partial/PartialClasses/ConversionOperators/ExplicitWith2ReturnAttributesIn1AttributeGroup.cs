namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static explicit operator ClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
