namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWith1GenericParameter
    {
        public T Method<T>()
        {
            return default(T);
        }
    }
}
