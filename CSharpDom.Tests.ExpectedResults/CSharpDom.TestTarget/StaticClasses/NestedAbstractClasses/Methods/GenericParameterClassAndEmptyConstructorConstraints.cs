namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
