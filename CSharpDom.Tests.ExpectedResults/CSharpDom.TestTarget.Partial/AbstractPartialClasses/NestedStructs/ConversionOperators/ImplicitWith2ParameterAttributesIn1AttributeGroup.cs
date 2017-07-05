namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            public static implicit operator Struct([Attribute1, Attribute2]string text)
            {
                return default(Struct);
            }
        }
    }
}
