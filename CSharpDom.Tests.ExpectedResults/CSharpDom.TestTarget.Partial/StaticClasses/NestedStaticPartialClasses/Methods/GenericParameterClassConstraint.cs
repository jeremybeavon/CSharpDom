namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
