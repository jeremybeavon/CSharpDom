namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithExplicitConversionOperator
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
