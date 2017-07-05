namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStaticClasses
{
    public struct StructWithNestedStructWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
