namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithExplicitConversionOperatorWith1Attribute
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
