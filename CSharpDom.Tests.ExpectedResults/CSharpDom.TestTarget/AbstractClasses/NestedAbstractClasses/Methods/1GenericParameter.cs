namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractClassWithMethodWith1GenericParameter
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
