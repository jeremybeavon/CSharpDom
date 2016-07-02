namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups([Attribute1][Attribute2]string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups);
        }
    }
}
