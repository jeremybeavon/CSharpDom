namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
