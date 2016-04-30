namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public interface Interface
            {
            }
        }
    }
}
