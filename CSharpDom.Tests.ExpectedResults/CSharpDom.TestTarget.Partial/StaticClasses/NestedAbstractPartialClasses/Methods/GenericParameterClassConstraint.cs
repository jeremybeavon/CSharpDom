namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods
{
    public static class StaticClassWithNestedAbstractPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
