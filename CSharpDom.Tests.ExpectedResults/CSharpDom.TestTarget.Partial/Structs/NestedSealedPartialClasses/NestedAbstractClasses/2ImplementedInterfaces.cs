namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedAbstractPartialClassWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
