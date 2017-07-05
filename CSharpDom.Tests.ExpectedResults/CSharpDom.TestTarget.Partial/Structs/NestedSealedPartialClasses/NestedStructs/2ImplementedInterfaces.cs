namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
