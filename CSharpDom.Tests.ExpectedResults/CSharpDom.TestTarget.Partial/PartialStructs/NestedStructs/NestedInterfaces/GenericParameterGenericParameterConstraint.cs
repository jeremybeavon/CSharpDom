namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
