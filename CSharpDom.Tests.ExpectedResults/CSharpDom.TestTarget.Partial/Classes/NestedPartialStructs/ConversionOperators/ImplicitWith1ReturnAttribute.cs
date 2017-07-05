namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
