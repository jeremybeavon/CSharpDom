namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedInterfaces
{
    public struct StructWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
