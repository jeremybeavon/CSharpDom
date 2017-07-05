namespace CSharpDom.TestTarget.Partial.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, new()
        {
        }
    }
}
