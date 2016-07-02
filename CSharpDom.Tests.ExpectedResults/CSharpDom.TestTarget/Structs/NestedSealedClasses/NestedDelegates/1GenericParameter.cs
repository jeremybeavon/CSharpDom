namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates
{
    public struct StructWithNestedSealedClassWithNestedDelegateWith1GenericParameter
    {
        public sealed class Class
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
