namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedInterfaces
{
    public struct StructWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
