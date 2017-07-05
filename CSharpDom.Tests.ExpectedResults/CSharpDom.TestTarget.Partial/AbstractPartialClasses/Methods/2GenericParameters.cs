namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWith2GenericParameters
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
