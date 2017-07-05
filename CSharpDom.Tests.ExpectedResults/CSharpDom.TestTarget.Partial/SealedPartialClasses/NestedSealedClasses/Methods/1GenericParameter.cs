namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithMethodWith1GenericParameter
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
