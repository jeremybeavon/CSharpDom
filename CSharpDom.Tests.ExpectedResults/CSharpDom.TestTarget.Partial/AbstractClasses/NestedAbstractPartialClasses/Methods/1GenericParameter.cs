namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithMethodWith1GenericParameter
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
