namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Methods
{
    public static partial class StaticPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public static Dictionary<TKey, TValue> Method<TKey, TValue>()
            where TValue : TKey
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
