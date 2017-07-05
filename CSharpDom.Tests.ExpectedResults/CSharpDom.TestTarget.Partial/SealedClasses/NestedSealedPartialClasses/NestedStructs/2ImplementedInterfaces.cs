namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
