namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.ConversionOperators
{
    public class ClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public static implicit operator Struct(string text)
            {
                return default(Struct);
            }
        }
    }
}
