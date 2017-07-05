namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitConversionOperatorWith1Attribute
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
