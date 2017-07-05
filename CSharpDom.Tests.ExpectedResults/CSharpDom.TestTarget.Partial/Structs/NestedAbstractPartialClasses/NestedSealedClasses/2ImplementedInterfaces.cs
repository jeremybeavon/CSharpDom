namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedSealedPartialClassWith2ImplementedInterfaces
    {
        public abstract partial class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
