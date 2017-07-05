namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedPartialClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
