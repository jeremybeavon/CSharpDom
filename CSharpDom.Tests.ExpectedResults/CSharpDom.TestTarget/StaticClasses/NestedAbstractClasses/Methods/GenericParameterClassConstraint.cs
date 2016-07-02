namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint
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
