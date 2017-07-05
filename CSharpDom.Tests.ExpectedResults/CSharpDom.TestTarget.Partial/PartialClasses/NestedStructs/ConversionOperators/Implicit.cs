namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithImplicitConversionOperator
    {
        public struct Struct
        {
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
