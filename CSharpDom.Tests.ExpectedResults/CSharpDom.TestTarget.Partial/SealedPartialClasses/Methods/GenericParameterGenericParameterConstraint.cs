namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
