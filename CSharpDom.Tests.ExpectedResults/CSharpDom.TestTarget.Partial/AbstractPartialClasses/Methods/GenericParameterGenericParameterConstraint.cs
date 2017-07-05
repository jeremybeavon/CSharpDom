namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
