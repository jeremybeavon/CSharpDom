namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedDelegateWith2GenericParameters
    {
        public struct Struct
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
