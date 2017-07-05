namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedSealedPartialClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
