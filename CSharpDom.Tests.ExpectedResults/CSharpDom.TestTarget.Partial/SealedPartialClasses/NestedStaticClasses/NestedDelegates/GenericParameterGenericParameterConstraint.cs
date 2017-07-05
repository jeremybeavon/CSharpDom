namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
