namespace CSharpDom.TestTarget.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
