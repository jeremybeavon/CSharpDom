namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithExplicitConversionOperatorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
