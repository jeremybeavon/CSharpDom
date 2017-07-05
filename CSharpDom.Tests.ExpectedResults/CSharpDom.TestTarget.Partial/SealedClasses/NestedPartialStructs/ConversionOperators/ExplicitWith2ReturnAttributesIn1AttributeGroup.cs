namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup
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
