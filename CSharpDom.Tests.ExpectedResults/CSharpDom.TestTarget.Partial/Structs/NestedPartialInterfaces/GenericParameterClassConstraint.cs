namespace CSharpDom.TestTarget.Partial.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
