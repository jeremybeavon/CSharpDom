namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWith2GenericParameters
    {
        public static Dictionary<TKey, TValue> Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
