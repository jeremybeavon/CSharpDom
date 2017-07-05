namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
