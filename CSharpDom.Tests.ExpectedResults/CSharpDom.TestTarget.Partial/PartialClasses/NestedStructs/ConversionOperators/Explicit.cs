namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithExplicitConversionOperator
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
