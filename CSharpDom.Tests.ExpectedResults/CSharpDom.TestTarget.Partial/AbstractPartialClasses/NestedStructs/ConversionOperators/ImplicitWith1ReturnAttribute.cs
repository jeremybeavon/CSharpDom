namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute
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
