namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Methods
{
    public sealed class SealedClassWithNestedStaticClassWithMethodWith2GenericParameters
    {
        public static class Class
        {
            public static Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
