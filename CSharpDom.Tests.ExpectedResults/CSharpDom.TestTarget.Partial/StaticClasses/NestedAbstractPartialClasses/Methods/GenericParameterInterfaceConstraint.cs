namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods
{
    public static class StaticClassWithNestedAbstractPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
