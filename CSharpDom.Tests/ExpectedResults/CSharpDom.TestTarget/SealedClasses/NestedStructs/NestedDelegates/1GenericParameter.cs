namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWith1GenericParameter
    {
        public struct Struct
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
