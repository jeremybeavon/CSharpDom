namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
