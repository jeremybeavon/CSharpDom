namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public static explicit operator Struct([Attribute1][Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
