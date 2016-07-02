namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWith1GenericParameter
    {
        public struct Struct
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
