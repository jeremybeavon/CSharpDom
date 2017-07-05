namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.ConversionOperators
{
    public struct StructWithNestedPartialClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
