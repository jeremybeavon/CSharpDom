namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedSealedClasses
{
    public partial struct PartialStructWithNestedStructWithNestedSealedClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
