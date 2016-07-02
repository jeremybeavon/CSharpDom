namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
