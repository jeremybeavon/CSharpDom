namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates
{
    public struct StructWithNestedAbstractClassWithNestedDelegateWith2GenericParameters
    {
        public abstract class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
