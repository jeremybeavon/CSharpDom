namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
