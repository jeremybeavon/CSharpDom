namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWith2GenericParameters
    {
        public struct Struct
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
