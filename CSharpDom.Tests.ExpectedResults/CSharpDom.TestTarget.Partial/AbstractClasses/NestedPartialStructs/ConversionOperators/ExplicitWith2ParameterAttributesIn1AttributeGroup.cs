namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup
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
