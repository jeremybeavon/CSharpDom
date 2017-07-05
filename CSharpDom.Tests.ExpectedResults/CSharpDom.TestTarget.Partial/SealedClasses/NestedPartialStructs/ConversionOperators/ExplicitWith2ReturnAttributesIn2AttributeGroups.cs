namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.ConversionOperators
{
    public sealed class SealedClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
