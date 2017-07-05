namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            public static explicit operator Struct([Attribute1, Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
