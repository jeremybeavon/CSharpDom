namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
