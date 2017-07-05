namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
