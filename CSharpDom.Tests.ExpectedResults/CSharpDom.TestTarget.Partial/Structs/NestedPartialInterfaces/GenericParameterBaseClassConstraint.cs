namespace CSharpDom.TestTarget.Partial.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
