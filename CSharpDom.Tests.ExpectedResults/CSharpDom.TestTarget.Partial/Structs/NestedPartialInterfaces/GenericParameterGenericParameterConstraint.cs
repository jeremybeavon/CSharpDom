namespace CSharpDom.TestTarget.Partial.Structs.NestedInterfaces
{
    public struct StructWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
