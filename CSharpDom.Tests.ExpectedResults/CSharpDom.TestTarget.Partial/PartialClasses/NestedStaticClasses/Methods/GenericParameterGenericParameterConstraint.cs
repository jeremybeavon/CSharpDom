namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Methods
{
    public partial class PartialClassWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraint
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
