namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedDelegateWith2GenericParameters
    {
        public struct Struct
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
