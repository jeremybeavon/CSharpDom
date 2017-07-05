namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
