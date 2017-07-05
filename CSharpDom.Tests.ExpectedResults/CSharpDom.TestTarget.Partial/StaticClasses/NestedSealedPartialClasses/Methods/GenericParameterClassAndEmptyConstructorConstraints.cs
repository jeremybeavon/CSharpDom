namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
