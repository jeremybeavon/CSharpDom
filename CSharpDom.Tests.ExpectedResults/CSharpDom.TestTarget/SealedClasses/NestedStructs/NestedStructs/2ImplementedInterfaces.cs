namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
