namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
