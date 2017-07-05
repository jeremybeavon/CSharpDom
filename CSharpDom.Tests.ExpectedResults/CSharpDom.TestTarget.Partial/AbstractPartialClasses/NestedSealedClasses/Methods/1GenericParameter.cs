namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithMethodWith1GenericParameter
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
