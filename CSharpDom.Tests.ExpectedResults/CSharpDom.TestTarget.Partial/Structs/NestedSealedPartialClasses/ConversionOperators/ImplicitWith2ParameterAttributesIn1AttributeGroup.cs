namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.ConversionOperators
{
    public struct StructWithNestedSealedPartialClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            public static implicit operator Class([Attribute1, Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
