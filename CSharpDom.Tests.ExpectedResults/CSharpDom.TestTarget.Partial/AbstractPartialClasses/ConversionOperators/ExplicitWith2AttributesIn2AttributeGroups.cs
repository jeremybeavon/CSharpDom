namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
