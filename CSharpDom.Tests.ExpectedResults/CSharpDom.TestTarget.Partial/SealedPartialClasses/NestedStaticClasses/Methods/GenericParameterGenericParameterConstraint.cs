namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraint
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
