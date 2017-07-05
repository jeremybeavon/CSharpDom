namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithMethodWith1GenericParameter
    {
        public struct Struct
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
