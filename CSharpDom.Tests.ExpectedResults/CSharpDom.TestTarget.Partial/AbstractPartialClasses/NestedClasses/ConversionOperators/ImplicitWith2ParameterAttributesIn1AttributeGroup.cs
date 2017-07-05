namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
