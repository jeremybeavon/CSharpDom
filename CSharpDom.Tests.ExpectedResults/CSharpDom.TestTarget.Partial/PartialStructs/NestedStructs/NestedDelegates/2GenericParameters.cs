namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStructWithNestedDelegateWith2GenericParameters
    {
        public struct Struct
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
