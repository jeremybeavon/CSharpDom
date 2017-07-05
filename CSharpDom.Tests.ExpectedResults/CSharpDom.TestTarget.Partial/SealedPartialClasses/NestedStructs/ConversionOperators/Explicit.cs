namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitConversionOperator
    {
        public struct Struct
        {
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
