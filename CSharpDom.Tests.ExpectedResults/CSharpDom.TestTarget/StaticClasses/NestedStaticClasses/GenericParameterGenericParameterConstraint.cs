namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
