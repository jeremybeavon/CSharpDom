namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWith1GenericParameter
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
