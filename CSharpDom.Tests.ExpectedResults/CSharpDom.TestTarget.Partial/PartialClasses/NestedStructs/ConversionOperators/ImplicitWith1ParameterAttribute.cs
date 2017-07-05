namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.ConversionOperators
{
    public partial class PartialClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute
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
