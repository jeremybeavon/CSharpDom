namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
