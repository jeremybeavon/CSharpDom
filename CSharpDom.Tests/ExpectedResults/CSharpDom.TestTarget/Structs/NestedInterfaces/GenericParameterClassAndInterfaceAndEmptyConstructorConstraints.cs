namespace CSharpDom.TestTarget.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, IInterface, new()
        {
        }
    }
}
