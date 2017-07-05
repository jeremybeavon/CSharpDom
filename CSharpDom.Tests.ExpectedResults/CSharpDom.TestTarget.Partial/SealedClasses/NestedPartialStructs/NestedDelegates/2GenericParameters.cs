namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWith2GenericParameters
    {
        public struct Struct
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
