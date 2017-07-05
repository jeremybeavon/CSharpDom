namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.ConversionOperators
{
    public static class StaticClassWithNestedPartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public partial class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
