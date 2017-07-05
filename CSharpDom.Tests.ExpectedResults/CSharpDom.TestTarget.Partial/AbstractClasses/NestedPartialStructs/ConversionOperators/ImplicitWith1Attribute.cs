namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithImplicitConversionOperatorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
