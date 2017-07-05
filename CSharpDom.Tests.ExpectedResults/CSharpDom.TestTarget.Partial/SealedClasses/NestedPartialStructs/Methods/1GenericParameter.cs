namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWith1GenericParameter
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
