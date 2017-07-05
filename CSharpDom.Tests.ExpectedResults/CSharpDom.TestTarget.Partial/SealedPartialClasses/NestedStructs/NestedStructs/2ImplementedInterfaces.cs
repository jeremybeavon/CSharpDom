namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStructWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
