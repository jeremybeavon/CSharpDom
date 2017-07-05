namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithMethodWith2GenericParameters
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
