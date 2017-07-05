namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public partial class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
