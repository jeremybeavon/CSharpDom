namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
