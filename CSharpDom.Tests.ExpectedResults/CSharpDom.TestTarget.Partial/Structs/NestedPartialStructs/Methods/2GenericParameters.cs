namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWith2GenericParameters
    {
        public struct Struct
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
