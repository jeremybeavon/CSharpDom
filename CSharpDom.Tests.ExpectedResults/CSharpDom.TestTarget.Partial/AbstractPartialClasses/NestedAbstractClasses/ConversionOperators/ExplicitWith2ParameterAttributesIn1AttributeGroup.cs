namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
