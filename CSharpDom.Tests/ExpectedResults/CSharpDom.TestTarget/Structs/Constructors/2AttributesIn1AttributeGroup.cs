namespace CSharpDom.TestTarget.Structs.Constructors
{
    public struct StructWithConstructorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public StructWithConstructorWith2AttributesIn1AttributeGroup(string text)
        {
        }
    }
}
