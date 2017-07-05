namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedDelegateWith1GenericParameter
    {
        public struct Struct
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
