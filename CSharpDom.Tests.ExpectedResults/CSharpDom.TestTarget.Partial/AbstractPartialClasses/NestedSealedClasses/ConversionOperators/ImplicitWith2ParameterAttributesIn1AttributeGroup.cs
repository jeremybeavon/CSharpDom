namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
