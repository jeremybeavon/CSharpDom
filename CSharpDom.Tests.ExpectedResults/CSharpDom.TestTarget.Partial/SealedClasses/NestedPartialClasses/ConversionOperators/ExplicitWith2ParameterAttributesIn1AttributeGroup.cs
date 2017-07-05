namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
