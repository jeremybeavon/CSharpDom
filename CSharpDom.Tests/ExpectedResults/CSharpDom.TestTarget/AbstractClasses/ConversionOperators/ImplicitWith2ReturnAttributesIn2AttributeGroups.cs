namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        [return: Attribute1]
        [return: Attribute2]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups);
        }
    }
}
