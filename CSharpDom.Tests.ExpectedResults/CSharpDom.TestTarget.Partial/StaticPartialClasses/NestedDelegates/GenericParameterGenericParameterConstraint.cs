namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
