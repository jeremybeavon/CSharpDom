namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedStructWithImplicitConversionOperatorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
