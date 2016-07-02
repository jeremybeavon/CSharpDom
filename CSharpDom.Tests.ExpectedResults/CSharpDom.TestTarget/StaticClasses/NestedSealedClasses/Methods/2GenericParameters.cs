namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods
{
    public static class StaticClassWithNestedSealedClassWithMethodWith2GenericParameters
    {
        public sealed class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
