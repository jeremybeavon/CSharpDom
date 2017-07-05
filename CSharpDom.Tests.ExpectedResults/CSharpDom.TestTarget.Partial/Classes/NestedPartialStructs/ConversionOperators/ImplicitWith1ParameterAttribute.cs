namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute
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
