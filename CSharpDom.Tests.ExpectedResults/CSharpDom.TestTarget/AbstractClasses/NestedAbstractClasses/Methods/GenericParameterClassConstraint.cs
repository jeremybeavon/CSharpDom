namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
