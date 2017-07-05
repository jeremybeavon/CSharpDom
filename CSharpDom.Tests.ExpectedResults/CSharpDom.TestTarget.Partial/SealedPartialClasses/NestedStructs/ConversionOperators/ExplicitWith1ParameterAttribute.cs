namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public struct Struct
        {
            public static explicit operator Struct([Attribute1]string text)
            {
                return default(Struct);
            }
        }
    }
}
