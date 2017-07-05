namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
