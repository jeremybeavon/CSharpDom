namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.ConversionOperators
{
    public struct StructWithNestedPartialClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
