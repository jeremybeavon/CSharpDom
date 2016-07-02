namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
