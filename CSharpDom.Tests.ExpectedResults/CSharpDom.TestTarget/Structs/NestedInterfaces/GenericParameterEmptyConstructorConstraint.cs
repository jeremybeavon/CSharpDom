namespace CSharpDom.TestTarget.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
