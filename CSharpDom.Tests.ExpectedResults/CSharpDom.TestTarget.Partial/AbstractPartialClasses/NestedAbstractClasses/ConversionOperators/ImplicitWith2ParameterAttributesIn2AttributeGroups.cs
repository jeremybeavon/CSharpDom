namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
