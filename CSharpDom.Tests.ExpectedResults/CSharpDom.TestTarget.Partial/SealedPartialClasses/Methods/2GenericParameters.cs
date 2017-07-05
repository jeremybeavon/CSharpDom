namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWith2GenericParameters
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
