namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
