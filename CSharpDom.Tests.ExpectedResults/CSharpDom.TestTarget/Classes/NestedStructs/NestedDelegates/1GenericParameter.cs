namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedDelegateWith1GenericParameter
    {
        public struct Struct
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
