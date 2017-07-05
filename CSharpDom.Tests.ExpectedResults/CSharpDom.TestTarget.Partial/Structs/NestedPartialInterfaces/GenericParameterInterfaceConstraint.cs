namespace CSharpDom.TestTarget.Partial.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
