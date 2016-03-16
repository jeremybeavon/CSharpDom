namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups);
        }
    }
}
