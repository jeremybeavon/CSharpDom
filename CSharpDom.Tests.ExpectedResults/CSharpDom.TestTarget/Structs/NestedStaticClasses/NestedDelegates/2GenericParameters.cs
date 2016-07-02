namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedDelegates
{
    public struct StructWithNestedStaticClassWithNestedDelegateWith2GenericParameters
    {
        public static class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
