namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public static explicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
