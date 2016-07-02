namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
