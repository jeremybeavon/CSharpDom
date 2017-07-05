namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
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
