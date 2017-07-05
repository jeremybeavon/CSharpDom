namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods
{
    public struct StructWithNestedAbstractPartialClassWithMethodWith1GenericParameter
    {
        public abstract partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
