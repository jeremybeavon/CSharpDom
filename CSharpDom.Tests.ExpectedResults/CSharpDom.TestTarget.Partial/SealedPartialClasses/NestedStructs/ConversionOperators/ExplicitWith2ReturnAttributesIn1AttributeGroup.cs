namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [return: Attribute1, Attribute2]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
