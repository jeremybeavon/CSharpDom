namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
