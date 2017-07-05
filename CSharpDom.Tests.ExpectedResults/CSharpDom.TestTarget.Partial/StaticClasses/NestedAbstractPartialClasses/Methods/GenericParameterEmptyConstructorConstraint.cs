namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods
{
    public static class StaticClassWithNestedAbstractPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
