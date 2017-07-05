namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWith1GenericParameter
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
