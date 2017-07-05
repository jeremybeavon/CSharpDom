namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public struct Struct
        {
            public static implicit operator Struct([Attribute1]string text)
            {
                return default(Struct);
            }
        }
    }
}
