namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithImplicitConversionOperator
    {
        public struct Struct
        {
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
