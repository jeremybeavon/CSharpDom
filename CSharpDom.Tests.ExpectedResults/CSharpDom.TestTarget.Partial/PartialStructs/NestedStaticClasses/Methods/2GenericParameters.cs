namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Methods
{
    public partial struct PartialStructWithWithNestedStaticClassWithMethodWith2GenericParameters
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
