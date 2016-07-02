namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithMethodWith1GenericParameter
    {
        public sealed class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
