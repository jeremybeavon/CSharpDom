namespace CSharpDom.TestTarget.SealedClasses.Methods
{
    public sealed class SealedClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
