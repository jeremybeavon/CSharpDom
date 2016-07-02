namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
