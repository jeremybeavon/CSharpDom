namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithExplicitConversionOperatorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
