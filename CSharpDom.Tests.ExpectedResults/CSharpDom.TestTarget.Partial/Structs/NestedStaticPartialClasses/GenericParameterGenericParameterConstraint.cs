namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
