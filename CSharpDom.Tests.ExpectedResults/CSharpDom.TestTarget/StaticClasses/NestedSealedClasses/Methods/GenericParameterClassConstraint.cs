namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods
{
    public static class StaticClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
