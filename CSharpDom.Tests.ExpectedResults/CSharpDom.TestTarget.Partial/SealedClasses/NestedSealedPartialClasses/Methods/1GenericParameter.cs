namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMethodWith1GenericParameter
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
