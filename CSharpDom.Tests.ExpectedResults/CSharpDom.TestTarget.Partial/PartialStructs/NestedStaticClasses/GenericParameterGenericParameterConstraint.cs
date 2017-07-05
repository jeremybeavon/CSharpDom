namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
