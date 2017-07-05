namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute
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
