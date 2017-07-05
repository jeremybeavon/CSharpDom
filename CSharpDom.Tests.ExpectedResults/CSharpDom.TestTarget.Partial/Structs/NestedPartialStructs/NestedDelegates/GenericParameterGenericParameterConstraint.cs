namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
