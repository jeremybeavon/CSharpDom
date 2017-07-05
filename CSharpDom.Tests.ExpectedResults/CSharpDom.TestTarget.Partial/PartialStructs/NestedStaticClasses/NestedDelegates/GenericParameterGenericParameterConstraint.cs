namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
