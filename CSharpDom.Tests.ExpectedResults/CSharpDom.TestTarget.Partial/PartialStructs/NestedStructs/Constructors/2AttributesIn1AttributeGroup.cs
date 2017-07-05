namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Constructors
{
    public partial struct PartialStructWithWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public Struct(string text)
            {
            }
        }
    }
}
