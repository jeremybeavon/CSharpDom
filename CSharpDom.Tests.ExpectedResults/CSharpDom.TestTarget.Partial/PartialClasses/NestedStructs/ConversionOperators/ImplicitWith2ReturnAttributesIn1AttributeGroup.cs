namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [return: Attribute1, Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
