namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
