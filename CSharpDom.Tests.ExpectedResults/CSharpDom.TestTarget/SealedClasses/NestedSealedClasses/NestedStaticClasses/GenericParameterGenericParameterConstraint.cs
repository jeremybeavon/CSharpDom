namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
