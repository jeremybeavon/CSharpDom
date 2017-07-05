namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithImplicitConversionOperator
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
