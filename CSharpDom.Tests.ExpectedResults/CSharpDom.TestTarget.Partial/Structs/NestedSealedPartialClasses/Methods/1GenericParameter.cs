namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithMethodWith1GenericParameter
    {
        public sealed partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
