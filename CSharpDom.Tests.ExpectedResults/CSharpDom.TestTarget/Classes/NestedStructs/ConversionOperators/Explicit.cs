namespace CSharpDom.TestTarget.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithExplicitConversionOperator
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
