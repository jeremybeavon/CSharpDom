namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
