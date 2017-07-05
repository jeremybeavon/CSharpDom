namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
