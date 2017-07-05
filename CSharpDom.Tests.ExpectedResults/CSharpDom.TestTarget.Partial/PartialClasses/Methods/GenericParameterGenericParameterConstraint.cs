namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
