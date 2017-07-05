namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Methods
{
    public static partial class StaticPartialClassWithNestedStaticClassWithMethodWith2GenericParameters
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
