namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
