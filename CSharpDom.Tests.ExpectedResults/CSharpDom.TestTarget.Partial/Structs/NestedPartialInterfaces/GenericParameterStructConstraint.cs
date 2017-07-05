namespace CSharpDom.TestTarget.Partial.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
