namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWith1GenericParameter
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
