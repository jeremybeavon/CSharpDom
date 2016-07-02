namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraint
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
