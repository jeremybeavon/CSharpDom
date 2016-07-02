namespace CSharpDom.TestTarget.Structs.NestedDelegates
{
    public struct StructWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
