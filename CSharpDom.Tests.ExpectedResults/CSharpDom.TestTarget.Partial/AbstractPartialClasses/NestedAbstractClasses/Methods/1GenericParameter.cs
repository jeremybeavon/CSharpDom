namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithMethodWith1GenericParameter
    {
        public abstract class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
