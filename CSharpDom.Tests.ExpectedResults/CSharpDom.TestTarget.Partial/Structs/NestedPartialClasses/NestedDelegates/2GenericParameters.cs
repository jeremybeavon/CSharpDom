namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedDelegates
{
    public struct StructWithNestedPartialClassWithNestedDelegateWith2GenericParameters
    {
        public partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
