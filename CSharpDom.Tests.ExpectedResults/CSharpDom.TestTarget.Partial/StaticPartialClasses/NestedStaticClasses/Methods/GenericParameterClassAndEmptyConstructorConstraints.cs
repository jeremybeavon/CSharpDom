namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Methods
{
    public static partial class StaticPartialClassWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
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
