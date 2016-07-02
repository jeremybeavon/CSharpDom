namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
