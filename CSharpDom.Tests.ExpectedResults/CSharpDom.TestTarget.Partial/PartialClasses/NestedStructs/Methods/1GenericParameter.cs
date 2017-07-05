namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWith1GenericParameter
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
