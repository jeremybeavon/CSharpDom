namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        [return: Attribute1, Attribute2]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup);
        }
    }
}
