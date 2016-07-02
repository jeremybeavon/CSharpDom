namespace CSharpDom.TestTarget.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
