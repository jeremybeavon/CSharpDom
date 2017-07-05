namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public interface Interface
            {
            }
        }
    }
}
