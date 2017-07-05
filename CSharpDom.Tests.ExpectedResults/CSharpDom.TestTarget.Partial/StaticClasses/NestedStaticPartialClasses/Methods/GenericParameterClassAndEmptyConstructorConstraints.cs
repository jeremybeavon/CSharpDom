namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
