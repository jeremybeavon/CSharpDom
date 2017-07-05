namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods
{
    public static class StaticClassWithNestedPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
