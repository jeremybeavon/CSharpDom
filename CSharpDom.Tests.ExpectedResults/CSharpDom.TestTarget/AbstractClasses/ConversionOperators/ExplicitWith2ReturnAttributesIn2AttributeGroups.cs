namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
