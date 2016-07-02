namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
