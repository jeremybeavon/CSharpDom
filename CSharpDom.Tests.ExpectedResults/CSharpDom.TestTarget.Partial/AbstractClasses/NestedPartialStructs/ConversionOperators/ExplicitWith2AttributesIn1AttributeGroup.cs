namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
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
