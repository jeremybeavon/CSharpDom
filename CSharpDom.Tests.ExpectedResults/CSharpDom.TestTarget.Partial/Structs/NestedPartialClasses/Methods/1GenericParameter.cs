namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWith1GenericParameter
    {
        public partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
