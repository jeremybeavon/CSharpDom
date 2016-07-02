namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
