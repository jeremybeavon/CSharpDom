namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Methods
{
    public partial struct PartialStructWithWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public static Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
