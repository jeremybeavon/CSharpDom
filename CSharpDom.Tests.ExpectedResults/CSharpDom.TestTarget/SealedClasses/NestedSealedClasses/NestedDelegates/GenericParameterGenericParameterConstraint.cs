namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
