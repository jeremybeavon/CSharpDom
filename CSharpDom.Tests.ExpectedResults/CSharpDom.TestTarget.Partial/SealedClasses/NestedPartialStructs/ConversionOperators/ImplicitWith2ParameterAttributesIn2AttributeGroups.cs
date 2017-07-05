namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public static implicit operator Struct([Attribute1][Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
