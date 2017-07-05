namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static implicit operator ClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
